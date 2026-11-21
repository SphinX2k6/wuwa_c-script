using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CE0 RID: 19680
	[NullableContext(1)]
	[Nullable(0)]
	public class Code12 : CodeNBase
	{
		// Token: 0x06031417 RID: 201751 RVA: 0x00DC1187 File Offset: 0x00DBF387
		public override Dictionary<string, int[]> GetCodeTable()
		{
			return Code12.CodeTable;
		}

		// Token: 0x06031418 RID: 201752 RVA: 0x00DC118E File Offset: 0x00DBF38E
		public override int SingleCodeLength()
		{
			return 4;
		}

		// Token: 0x06031419 RID: 201753 RVA: 0x00DC1191 File Offset: 0x00DBF391
		public override int SupportCharCount()
		{
			return 10;
		}

		// Token: 0x0603141B RID: 201755 RVA: 0x00DC11A0 File Offset: 0x00DBF3A0
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

		// Token: 0x0401A152 RID: 106834
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int[]> CodeTable;
	}
}
