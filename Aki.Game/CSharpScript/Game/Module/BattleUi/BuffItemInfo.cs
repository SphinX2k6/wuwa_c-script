using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi.Views;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C89 RID: 19593
	public class BuffItemInfo : IStaticVariableResetter
	{
		// Token: 0x06030E1C RID: 200220 RVA: 0x00DA24E7 File Offset: 0x00DA06E7
		static BuffItemInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BuffItemInfo.CreateStaticDefaultValue), new Action(BuffItemInfo.ResetStaticDefaultValue));
		}

		// Token: 0x06030E1D RID: 200221 RVA: 0x00DA2506 File Offset: 0x00DA0706
		public static void CreateStaticDefaultValue()
		{
			BuffItemInfo.Increment = 0;
		}

		// Token: 0x06030E1E RID: 200222 RVA: 0x00DA250E File Offset: 0x00DA070E
		public static void ResetStaticDefaultValue()
		{
			BuffItemInfo.Increment = 0;
		}

		// Token: 0x06030E1F RID: 200223 RVA: 0x00DA2516 File Offset: 0x00DA0716
		public static int GenSortId()
		{
			BuffItemInfo.Increment++;
			return BuffItemInfo.Increment;
		}

		// Token: 0x06030E20 RID: 200224 RVA: 0x00DA252C File Offset: 0x00DA072C
		[NullableContext(1)]
		public static int Compare(BuffItemInfo a, BuffItemInfo b)
		{
			int num = b.Priority - a.Priority;
			if (num == 0)
			{
				return b.SortId - a.SortId;
			}
			return num;
		}

		// Token: 0x06030E21 RID: 200225 RVA: 0x00DA2559 File Offset: 0x00DA0759
		public void Clear()
		{
			this.SingleBuff = null;
			this.BuffHandleSet.Clear();
			this.BuffItem = null;
		}

		// Token: 0x04019F0C RID: 106252
		public int SortId;

		// Token: 0x04019F0D RID: 106253
		public int Priority;

		// Token: 0x04019F0E RID: 106254
		public GameplayCue? BuffCueConfig;

		// Token: 0x04019F0F RID: 106255
		[Nullable(2)]
		public IActiveBuff SingleBuff;

		// Token: 0x04019F10 RID: 106256
		[Nullable(1)]
		public HashSet<long> BuffHandleSet = new HashSet<long>();

		// Token: 0x04019F11 RID: 106257
		[Nullable(2)]
		public BuffItemBase BuffItem;

		// Token: 0x04019F12 RID: 106258
		private static int Increment;
	}
}
