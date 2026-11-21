using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A05 RID: 14853
	public interface ITrapDefenseResultUnlockInfo
	{
		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x06026387 RID: 156551
		// (set) Token: 0x06026388 RID: 156552
		ETrapDefenseResultUnlockType Type { get; set; }

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x06026389 RID: 156553
		// (set) Token: 0x0602638A RID: 156554
		int Id { get; set; }

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x0602638B RID: 156555
		// (set) Token: 0x0602638C RID: 156556
		bool? NeedUnlockBar { get; set; }

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x0602638D RID: 156557
		// (set) Token: 0x0602638E RID: 156558
		bool? IsFinish { get; set; }

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x0602638F RID: 156559
		// (set) Token: 0x06026390 RID: 156560
		bool? IsNewUnlock { get; set; }

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x06026391 RID: 156561
		// (set) Token: 0x06026392 RID: 156562
		bool? ForShare { get; set; }
	}
}
