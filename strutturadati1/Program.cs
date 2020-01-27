using System;
using System.Collections.Generic;
using System.IO;

namespace strutturadati1
{
    class Program
    {
        private const string file_prova = @"fileprova.txt";
        private const string file = @"file.txt";
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            using (StreamReader filee = new StreamReader(file_prova))
            {
                string line;
                while ((line = filee.ReadLine()) != null)
                {
                    double a = double.Parse(line);
                    list.Add(a);
                }

            }


        }
    }
}
