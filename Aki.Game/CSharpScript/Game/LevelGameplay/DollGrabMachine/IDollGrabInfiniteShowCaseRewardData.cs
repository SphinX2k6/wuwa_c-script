using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006044 RID: 24644
	public interface IDollGrabInfiniteShowCaseRewardData
	{
		// Token: 0x17006FE9 RID: 28649
		// (get) Token: 0x0603B267 RID: 242279
		// (set) Token: 0x0603B268 RID: 242280
		int DropId { get; set; }

		// Token: 0x17006FEA RID: 28650
		// (get) Token: 0x0603B269 RID: 242281
		// (set) Token: 0x0603B26A RID: 242282
		int GetRewardIndex { get; set; }

		// Token: 0x17006FEB RID: 28651
		// (get) Token: 0x0603B26B RID: 242283
		// (set) Token: 0x0603B26C RID: 242284
		int NextRewardIndex { get; set; }
	}
}
