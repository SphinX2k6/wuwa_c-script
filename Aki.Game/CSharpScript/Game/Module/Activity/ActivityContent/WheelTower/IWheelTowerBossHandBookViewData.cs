using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F1A RID: 20250
	public interface IWheelTowerBossHandBookViewData
	{
		// Token: 0x17006302 RID: 25346
		// (get) Token: 0x06032E1E RID: 208414
		// (set) Token: 0x06032E1F RID: 208415
		bool IsEndless { get; set; }

		// Token: 0x17006303 RID: 25347
		// (get) Token: 0x06032E20 RID: 208416
		// (set) Token: 0x06032E21 RID: 208417
		int BossId { get; set; }

		// Token: 0x17006304 RID: 25348
		// (get) Token: 0x06032E22 RID: 208418
		// (set) Token: 0x06032E23 RID: 208419
		int BossRound { get; set; }

		// Token: 0x17006305 RID: 25349
		// (get) Token: 0x06032E24 RID: 208420
		// (set) Token: 0x06032E25 RID: 208421
		int TeamRound { get; set; }
	}
}
