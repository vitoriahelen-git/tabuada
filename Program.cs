using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Tabuada"); 
            Console.Write("Digite um numero inteiro: "); 
            numero = Convert.ToInt32(Console.ReadLine());
            
            for (int x = 0; x<=10; x++)
            {
                Console.WriteLine($"{numero} x {x} = " + ((numero * x)));  
            }
        }     
    }
}
