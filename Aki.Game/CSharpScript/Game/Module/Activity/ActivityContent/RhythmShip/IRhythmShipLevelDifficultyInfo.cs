using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x02006201 RID: 25089
	public interface IRhythmShipLevelDifficultyInfo
	{
		// Token: 0x17009230 RID: 37424
		// (get) Token: 0x0603F4EC RID: 259308
		// (set) Token: 0x0603F4ED RID: 259309
		int HistoryScore { get; set; }

		// Token: 0x17009231 RID: 37425
		// (get) Token: 0x0603F4EE RID: 259310
		// (set) Token: 0x0603F4EF RID: 259311
		int Accuracy { get; set; }

		// Token: 0x17009232 RID: 37426
		// (get) Token: 0x0603F4F0 RID: 259312
		// (set) Token: 0x0603F4F1 RID: 259313
		int Rating { get; set; }
	}
}
