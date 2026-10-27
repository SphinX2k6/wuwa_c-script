using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi.Views;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA7 RID: 23719
	public class BuffItemInfo : IStaticVariableResetter
	{
		// Token: 0x0603BEC9 RID: 245449 RVA: 0x00E51E3F File Offset: 0x00E5003F
		static BuffItemInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BuffItemInfo.CreateStaticDefaultValue), new Action(BuffItemInfo.ResetStaticDefaultValue));
		}

		// Token: 0x0603BECA RID: 245450 RVA: 0x00E51E5E File Offset: 0x00E5005E
		public static void CreateStaticDefaultValue()
		{
			BuffItemInfo.Increment = 0;
		}

		// Token: 0x0603BECB RID: 245451 RVA: 0x00E51E66 File Offset: 0x00E50066
		public static void ResetStaticDefaultValue()
		{
			BuffItemInfo.Increment = 0;
		}

		// Token: 0x0603BECC RID: 245452 RVA: 0x00E51E6E File Offset: 0x00E5006E
		public static int GenSortId()
		{
			BuffItemInfo.Increment++;
			return BuffItemInfo.Increment;
		}

		// Token: 0x0603BECD RID: 245453 RVA: 0x00E51E84 File Offset: 0x00E50084
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

		// Token: 0x0603BECE RID: 245454 RVA: 0x00E51EB1 File Offset: 0x00E500B1
		public void Clear()
		{
			this.SingleBuff = null;
			this.BuffHandleSet.Clear();
			this.BuffItem = null;
		}

		// Token: 0x0401F453 RID: 128083
		public int SortId;

		// Token: 0x0401F454 RID: 128084
		public int Priority;

		// Token: 0x0401F455 RID: 128085
		public GameplayCue? BuffCueConfig;

		// Token: 0x0401F456 RID: 128086
		[Nullable(2)]
		public IActiveBuff SingleBuff;

		// Token: 0x0401F457 RID: 128087
		[Nullable(1)]
		public HashSet<long> BuffHandleSet = new HashSet<long>();

		// Token: 0x0401F458 RID: 128088
		[Nullable(2)]
		public BuffItemBase BuffItem;

		// Token: 0x0401F459 RID: 128089
		private static int Increment;
	}
}
