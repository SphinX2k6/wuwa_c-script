using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200517F RID: 20863
	public interface IRhythmShipLevelDifficultyInfo
	{
		// Token: 0x17006592 RID: 26002
		// (get) Token: 0x060341AD RID: 213421
		// (set) Token: 0x060341AE RID: 213422
		int HistoryScore { get; set; }

		// Token: 0x17006593 RID: 26003
		// (get) Token: 0x060341AF RID: 213423
		// (set) Token: 0x060341B0 RID: 213424
		int Accuracy { get; set; }

		// Token: 0x17006594 RID: 26004
		// (get) Token: 0x060341B1 RID: 213425
		// (set) Token: 0x060341B2 RID: 213426
		int Rating { get; set; }
	}
}
