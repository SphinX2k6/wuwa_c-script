using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CFE RID: 23806
	[NullableContext(1)]
	[Nullable(0)]
	public class Code12 : CodeNBase
	{
		// Token: 0x0603C4BE RID: 246974 RVA: 0x00E70B1F File Offset: 0x00E6ED1F
		public override Dictionary<string, int[]> GetCodeTable()
		{
			return Code12.CodeTable;
		}

		// Token: 0x0603C4BF RID: 246975 RVA: 0x00E70B26 File Offset: 0x00E6ED26
		public override int SingleCodeLength()
		{
			return 4;
		}

		// Token: 0x0603C4C0 RID: 246976 RVA: 0x00E70B29 File Offset: 0x00E6ED29
		public override int SupportCharCount()
		{
			return 10;
		}

		// Token: 0x0603C4C2 RID: 246978 RVA: 0x00E70B38 File Offset: 0x00E6ED38
		// Note: this type is marked as 'beforefieldinit'.
		static Code12()
		{
			Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
			Dictionary<string, int[]> dictionary2 = dictionary;
			string key = "+";
			int[] array = new int[4];
			array[0] = 2;
			dictionary2.Add(key, array);
			dictionary.Add("-", new int[]
			{
				2,
				0,
				0,
				1
			});
			Dictionary<string, int[]> dictionary3 = dictionary;
			string key2 = "0";
			int[] array2 = new int[4];
			array2[0] = 2;
			array2[2] = 1;
			dictionary3.Add(key2, array2);
			dictionary.Add("1", new int[]
			{
				2,
				0,
				1,
				1
			});
			Dictionary<string, int[]> dictionary4 = dictionary;
			string key3 = "2";
			int[] array3 = new int[4];
			array3[0] = 2;
			array3[1] = 1;
			dictionary4.Add(key3, array3);
			dictionary.Add("3", new int[]
			{
				2,
				1,
				0,
				1
			});
			dictionary.Add("4", new int[]
			{
				2,
				1,
				1,
				0
			});
			dictionary.Add("5", new int[]
			{
				2,
				1,
				1,
				1
			});
			Dictionary<string, int[]> dictionary5 = dictionary;
			string key4 = "6";
			int[] array4 = new int[4];
			array4[0] = 2;
			array4[2] = 2;
			dictionary5.Add(key4, array4);
			dictionary.Add("7", new int[]
			{
				2,
				0,
				2,
				1
			});
			dictionary.Add("8", new int[]
			{
				2,
				1,
				2,
				0
			});
			dictionary.Add("9", new int[]
			{
				2,
				1,
				2,
				1
			});
			Code12.CodeTable = dictionary;
		}

		// Token: 0x0401F699 RID: 128665
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int[]> CodeTable;
	}
}
