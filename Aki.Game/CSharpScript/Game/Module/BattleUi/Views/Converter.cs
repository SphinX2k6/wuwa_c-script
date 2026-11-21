using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CDC RID: 19676
	[NullableContext(1)]
	[Nullable(0)]
	public class Converter
	{
		// Token: 0x06031405 RID: 201733 RVA: 0x00DC0390 File Offset: 0x00DBE590
		public static string Convert(string inputStr, int baseNum, int to)
		{
			if (baseNum == to)
			{
				return inputStr;
			}
			if (to < 2 || to > 62 || baseNum < 2 || baseNum > 62)
			{
				return "";
			}
			double num = Converter.ConvertToDecimal(inputStr, baseNum);
			string text = "";
			while (num > 0.0)
			{
				char c = Converter.CodeTable[(int)num % to];
				text = new ReadOnlySpan<char>(ref c) + text;
				num = Math.Floor(num / (double)to);
			}
			return text;
		}

		// Token: 0x06031406 RID: 201734 RVA: 0x00DC0404 File Offset: 0x00DBE604
		private static double ConvertToDecimal(string inputStr, int baseNum)
		{
			double num = 0.0;
			for (int i = 0; i < inputStr.Length; i++)
			{
				num += (double)Converter.CodeTable.IndexOf(inputStr[i]) * Math.Pow((double)baseNum, (double)(inputStr.Length - i - 1));
			}
			return num;
		}

		// Token: 0x0401A14F RID: 106831
		private static readonly string CodeTable = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	}
}
