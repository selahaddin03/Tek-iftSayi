using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekÇiftSayi
{
    public class Sayi 
    {
        
        public int TK(int sayi1)
        {
            int sonuc = 0;
            if (sayi1%2==1)
                Console.WriteLine("Sayi1 tek sayı");
            if (sayi1%2==0)
                Console.WriteLine("sayi1 çift sayı");
            return sonuc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Sayi sayi= new Sayi();
           int sonuc =sayi.TK(9);
            Console.WriteLine( sonuc);
        }
    }
}
