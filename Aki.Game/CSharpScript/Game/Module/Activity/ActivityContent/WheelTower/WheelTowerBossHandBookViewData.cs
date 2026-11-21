using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F1B RID: 20251
	public class WheelTowerBossHandBookViewData : IWheelTowerBossHandBookViewData
	{
		// Token: 0x17006306 RID: 25350
		// (get) Token: 0x06032E26 RID: 208422 RVA: 0x00E4740D File Offset: 0x00E4560D
		// (set) Token: 0x06032E27 RID: 208423 RVA: 0x00E47415 File Offset: 0x00E45615
		public bool IsEndless { get; set; }

		// Token: 0x17006307 RID: 25351
		// (get) Token: 0x06032E28 RID: 208424 RVA: 0x00E4741E File Offset: 0x00E4561E
		// (set) Token: 0x06032E29 RID: 208425 RVA: 0x00E47426 File Offset: 0x00E45626
		public int BossId { get; set; }

		// Token: 0x17006308 RID: 25352
		// (get) Token: 0x06032E2A RID: 208426 RVA: 0x00E4742F File Offset: 0x00E4562F
		// (set) Token: 0x06032E2B RID: 208427 RVA: 0x00E47437 File Offset: 0x00E45637
		public int BossRound { get; set; }

		// Token: 0x17006309 RID: 25353
		// (get) Token: 0x06032E2C RID: 208428 RVA: 0x00E47440 File Offset: 0x00E45640
		// (set) Token: 0x06032E2D RID: 208429 RVA: 0x00E47448 File Offset: 0x00E45648
		public int TeamRound { get; set; }
	}
}
