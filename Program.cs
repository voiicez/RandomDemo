namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazı mı tura mı çıkış mı ? (y)-(t)-(ç) ");
            string giris = Console.ReadLine();
            Random rastgele = new Random();
            int sayi;
            int yaziTura;
            int bilme = 0;
            double tekrar = 0;


            while (giris != "ç")
            {
                sayi = rastgele.Next(0, 2); //0,1
                //if (giris == "y")
                //    yaziTura = 0;
                //else yaziTura = 1;

                //yaziTura = 0;
                //if (giris == "t")
                //    yaziTura = 1;
                yaziTura = giris == "y" ? 0 : 1;//ternary operator.

                if (yaziTura == sayi)
                {
                    Console.WriteLine("Bildiniz.");

                    bilme++;
                    

                }
                else
                {
                    Console.WriteLine("Bilemediniz.");
                    
                }
                Console.WriteLine("Yazı mı tura mı çıkış mı ? (y) - (t) - (ç)");
                giris = Console.ReadLine();
                tekrar++;

            }
            if (tekrar > 0)
            {
                double sans = bilme * 100 / tekrar;

                Console.WriteLine(sans);
            }
            
        }
    }
}