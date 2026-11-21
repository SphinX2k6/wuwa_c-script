using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F31 RID: 20273
	public interface IWheelTowerMedalGroupData
	{
		// Token: 0x1700638D RID: 25485
		// (get) Token: 0x06032F40 RID: 208704
		// (set) Token: 0x06032F41 RID: 208705
		int GroupId { get; set; }

		// Token: 0x1700638E RID: 25486
		// (get) Token: 0x06032F42 RID: 208706
		// (set) Token: 0x06032F43 RID: 208707
		int SeasonId { get; set; }

		// Token: 0x1700638F RID: 25487
		// (get) Token: 0x06032F44 RID: 208708
		// (set) Token: 0x06032F45 RID: 208709
		int CycleId { get; set; }

		// Token: 0x17006390 RID: 25488
		// (get) Token: 0x06032F46 RID: 208710
		// (set) Token: 0x06032F47 RID: 208711
		int Progress { get; set; }

		// Token: 0x17006391 RID: 25489
		// (get) Token: 0x06032F48 RID: 208712
		// (set) Token: 0x06032F49 RID: 208713
		long CompleteTime { get; set; }

		// Token: 0x17006392 RID: 25490
		// (get) Token: 0x06032F4A RID: 208714
		// (set) Token: 0x06032F4B RID: 208715
		int CurrentMedalId { get; set; }

		// Token: 0x17006393 RID: 25491
		// (get) Token: 0x06032F4C RID: 208716
		// (set) Token: 0x06032F4D RID: 208717
		int NextMedalId { get; set; }

		// Token: 0x17006394 RID: 25492
		// (get) Token: 0x06032F4E RID: 208718
		// (set) Token: 0x06032F4F RID: 208719
		int CurrentTarget { get; set; }

		// Token: 0x17006395 RID: 25493
		// (get) Token: 0x06032F50 RID: 208720
		// (set) Token: 0x06032F51 RID: 208721
		bool IsMaxLevel { get; set; }
	}
}
