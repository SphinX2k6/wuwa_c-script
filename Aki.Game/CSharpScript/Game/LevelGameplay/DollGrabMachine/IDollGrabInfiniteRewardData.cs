using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC0 RID: 28352
	public interface IDollGrabInfiniteRewardData
	{
		// Token: 0x17009AA0 RID: 39584
		// (get) Token: 0x0604509E RID: 282782
		// (set) Token: 0x0604509F RID: 282783
		int DropId { get; set; }

		// Token: 0x17009AA1 RID: 39585
		// (get) Token: 0x060450A0 RID: 282784
		// (set) Token: 0x060450A1 RID: 282785
		int CurrentScore { get; set; }

		// Token: 0x17009AA2 RID: 39586
		// (get) Token: 0x060450A2 RID: 282786
		// (set) Token: 0x060450A3 RID: 282787
		int CurrentAccumulatedScore { get; set; }

		// Token: 0x17009AA3 RID: 39587
		// (get) Token: 0x060450A4 RID: 282788
		// (set) Token: 0x060450A5 RID: 282789
		int TargetAccumulatedScore { get; set; }

		// Token: 0x17009AA4 RID: 39588
		// (get) Token: 0x060450A6 RID: 282790
		// (set) Token: 0x060450A7 RID: 282791
		int HighestScore { get; set; }

		// Token: 0x17009AA5 RID: 39589
		// (get) Token: 0x060450A8 RID: 282792
		// (set) Token: 0x060450A9 RID: 282793
		bool IsFinalReward { get; set; }

		// Token: 0x17009AA6 RID: 39590
		// (get) Token: 0x060450AA RID: 282794
		// (set) Token: 0x060450AB RID: 282795
		bool IsFirstGetReward { get; set; }
	}
}
