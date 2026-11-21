using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F32 RID: 20274
	public class WheelTowerMedalGroupData : IWheelTowerMedalGroupData
	{
		// Token: 0x17006396 RID: 25494
		// (get) Token: 0x06032F52 RID: 208722 RVA: 0x00E47A32 File Offset: 0x00E45C32
		// (set) Token: 0x06032F53 RID: 208723 RVA: 0x00E47A3A File Offset: 0x00E45C3A
		public int GroupId { get; set; }

		// Token: 0x17006397 RID: 25495
		// (get) Token: 0x06032F54 RID: 208724 RVA: 0x00E47A43 File Offset: 0x00E45C43
		// (set) Token: 0x06032F55 RID: 208725 RVA: 0x00E47A4B File Offset: 0x00E45C4B
		public int SeasonId { get; set; }

		// Token: 0x17006398 RID: 25496
		// (get) Token: 0x06032F56 RID: 208726 RVA: 0x00E47A54 File Offset: 0x00E45C54
		// (set) Token: 0x06032F57 RID: 208727 RVA: 0x00E47A5C File Offset: 0x00E45C5C
		public int CycleId { get; set; }

		// Token: 0x17006399 RID: 25497
		// (get) Token: 0x06032F58 RID: 208728 RVA: 0x00E47A65 File Offset: 0x00E45C65
		// (set) Token: 0x06032F59 RID: 208729 RVA: 0x00E47A6D File Offset: 0x00E45C6D
		public int Progress { get; set; }

		// Token: 0x1700639A RID: 25498
		// (get) Token: 0x06032F5A RID: 208730 RVA: 0x00E47A76 File Offset: 0x00E45C76
		// (set) Token: 0x06032F5B RID: 208731 RVA: 0x00E47A7E File Offset: 0x00E45C7E
		public long CompleteTime { get; set; }

		// Token: 0x1700639B RID: 25499
		// (get) Token: 0x06032F5C RID: 208732 RVA: 0x00E47A87 File Offset: 0x00E45C87
		// (set) Token: 0x06032F5D RID: 208733 RVA: 0x00E47A8F File Offset: 0x00E45C8F
		public int CurrentMedalId { get; set; }

		// Token: 0x1700639C RID: 25500
		// (get) Token: 0x06032F5E RID: 208734 RVA: 0x00E47A98 File Offset: 0x00E45C98
		// (set) Token: 0x06032F5F RID: 208735 RVA: 0x00E47AA0 File Offset: 0x00E45CA0
		public int NextMedalId { get; set; }

		// Token: 0x1700639D RID: 25501
		// (get) Token: 0x06032F60 RID: 208736 RVA: 0x00E47AA9 File Offset: 0x00E45CA9
		// (set) Token: 0x06032F61 RID: 208737 RVA: 0x00E47AB1 File Offset: 0x00E45CB1
		public int CurrentTarget { get; set; }

		// Token: 0x1700639E RID: 25502
		// (get) Token: 0x06032F62 RID: 208738 RVA: 0x00E47ABA File Offset: 0x00E45CBA
		// (set) Token: 0x06032F63 RID: 208739 RVA: 0x00E47AC2 File Offset: 0x00E45CC2
		public bool IsMaxLevel { get; set; }
	}
}
