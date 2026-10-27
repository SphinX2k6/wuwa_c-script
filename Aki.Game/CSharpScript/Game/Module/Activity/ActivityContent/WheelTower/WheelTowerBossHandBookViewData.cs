using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F34 RID: 24372
	public class WheelTowerBossHandBookViewData : IWheelTowerBossHandBookViewData
	{
		// Token: 0x17008F34 RID: 36660
		// (get) Token: 0x0603DE8B RID: 253579 RVA: 0x00EF56E1 File Offset: 0x00EF38E1
		// (set) Token: 0x0603DE8C RID: 253580 RVA: 0x00EF56E9 File Offset: 0x00EF38E9
		public bool IsEndless { get; set; }

		// Token: 0x17008F35 RID: 36661
		// (get) Token: 0x0603DE8D RID: 253581 RVA: 0x00EF56F2 File Offset: 0x00EF38F2
		// (set) Token: 0x0603DE8E RID: 253582 RVA: 0x00EF56FA File Offset: 0x00EF38FA
		public int BossId { get; set; }

		// Token: 0x17008F36 RID: 36662
		// (get) Token: 0x0603DE8F RID: 253583 RVA: 0x00EF5703 File Offset: 0x00EF3903
		// (set) Token: 0x0603DE90 RID: 253584 RVA: 0x00EF570B File Offset: 0x00EF390B
		public int BossRound { get; set; }

		// Token: 0x17008F37 RID: 36663
		// (get) Token: 0x0603DE91 RID: 253585 RVA: 0x00EF5714 File Offset: 0x00EF3914
		// (set) Token: 0x0603DE92 RID: 253586 RVA: 0x00EF571C File Offset: 0x00EF391C
		public int TeamRound { get; set; }
	}
}
