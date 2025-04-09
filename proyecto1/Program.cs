using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, suma;
            //Console.Readkey();
            Console.Write("ingrese num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("ingrese num3: ");
            num3 = int.Parse(Console.ReadLine());
            suma = num1 + num2 + num3;
            Console.WriteLine("la suma es : " + suma);
        }
    }
}
