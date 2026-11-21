using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006040 RID: 24640
	public interface IDollGrabInfiniteRewardData
	{
		// Token: 0x17006FD7 RID: 28631
		// (get) Token: 0x0603B23F RID: 242239
		// (set) Token: 0x0603B240 RID: 242240
		int DropId { get; set; }

		// Token: 0x17006FD8 RID: 28632
		// (get) Token: 0x0603B241 RID: 242241
		// (set) Token: 0x0603B242 RID: 242242
		int CurrentScore { get; set; }

		// Token: 0x17006FD9 RID: 28633
		// (get) Token: 0x0603B243 RID: 242243
		// (set) Token: 0x0603B244 RID: 242244
		int CurrentAccumulatedScore { get; set; }

		// Token: 0x17006FDA RID: 28634
		// (get) Token: 0x0603B245 RID: 242245
		// (set) Token: 0x0603B246 RID: 242246
		int TargetAccumulatedScore { get; set; }

		// Token: 0x17006FDB RID: 28635
		// (get) Token: 0x0603B247 RID: 242247
		// (set) Token: 0x0603B248 RID: 242248
		int HighestScore { get; set; }

		// Token: 0x17006FDC RID: 28636
		// (get) Token: 0x0603B249 RID: 242249
		// (set) Token: 0x0603B24A RID: 242250
		bool IsFinalReward { get; set; }

		// Token: 0x17006FDD RID: 28637
		// (get) Token: 0x0603B24B RID: 242251
		// (set) Token: 0x0603B24C RID: 242252
		bool IsFirstGetReward { get; set; }
	}
}
