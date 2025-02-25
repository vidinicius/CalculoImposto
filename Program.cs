using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua renda anual com salário: ");
            double salAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite sua renda anual com prestação de serviço: ");
            double prestServ = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            Console.WriteLine("Digite sua renda anual com ganho de capital: ");
            double ganhoCap = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite seus gastos médicos: ");
            double gastosMed = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite seus gastos educacionais: ");
            double gastosEdu = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double impSalMens;
            double salMens = salAnual / 12;
            
            if (salMens < 3000)
            {
                impSalMens = 0;
            }
            else if(salMens < 5000)
            {
                impSalMens = salMens * 0.1;
            }
            else
            {
                impSalMens = salMens * 0.2;
            }
            
            double impSalAnual = 12 * impSalMens;
            double impServ = 0.15 * prestServ;
            double impCap = 0.20 * ganhoCap;

            double impBruto = impSalAnual + impServ + impCap;
            
            double maxDedutivel = 0.30 * impBruto;
            double gastosTotais = gastosEdu + gastosMed;
            double abatimento;
            if (gastosTotais < maxDedutivel)
            {
                abatimento = gastosTotais;

            }
            else
            {
                abatimento = maxDedutivel;
            }

            Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA: \n ");
            Console.WriteLine("CONSOLIDADO DE RENDA: ");
            Console.WriteLine("Imposto sobre salário: " + impSalAnual.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto sobre serviços: " + impServ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto sobre ganho de capital: " + impCap.ToString("F2", CultureInfo.InvariantCulture) + "\n");
            Console.WriteLine("DEDUÇÕES: ");
            Console.WriteLine("Máximo dedutível: " + maxDedutivel.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Gastos dedutíveis: " + gastosTotais.ToString("F2", CultureInfo.InvariantCulture) + "\n");
            Console.WriteLine("RESUMO: ");
            Console.WriteLine("Imposto Bruto Total: " + impBruto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Abatimento: " + abatimento.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto devido: " + (impBruto - abatimento).ToString("F2", CultureInfo.InvariantCulture));









        }
    }
}
