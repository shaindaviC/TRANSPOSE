using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        Console.WriteLine("Enter the matrix row by row:");

        // Read matrix input
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(row[j]);
            }
        }

        // In-place transpose
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }

        // Print transposed matrix
        Console.WriteLine("\nTranspose:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
