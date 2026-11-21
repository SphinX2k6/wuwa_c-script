using System;
using System.Runtime.CompilerServices;

// Token: 0x020008A5 RID: 2213
[NullableContext(2)]
public interface IPinballLevelInfoData
{
	// Token: 0x17000C2A RID: 3114
	// (get) Token: 0x060063C6 RID: 25542
	// (set) Token: 0x060063C7 RID: 25543
	int LevelId { get; set; }

	// Token: 0x17000C2B RID: 3115
	// (get) Token: 0x060063C8 RID: 25544
	// (set) Token: 0x060063C9 RID: 25545
	int RealLevelId { get; set; }

	// Token: 0x17000C2C RID: 3116
	// (get) Token: 0x060063CA RID: 25546
	// (set) Token: 0x060063CB RID: 25547
	int[] LevelStarConditionIds { get; set; }

	// Token: 0x17000C2D RID: 3117
	// (get) Token: 0x060063CC RID: 25548
	// (set) Token: 0x060063CD RID: 25549
	int? LevelScore { get; set; }

	// Token: 0x17000C2E RID: 3118
	// (get) Token: 0x060063CE RID: 25550
	// (set) Token: 0x060063CF RID: 25551
	bool? LevelLock { get; set; }

	// Token: 0x17000C2F RID: 3119
	// (get) Token: 0x060063D0 RID: 25552
	// (set) Token: 0x060063D1 RID: 25553
	string LevelLockTexts { get; set; }

	// Token: 0x17000C30 RID: 3120
	// (get) Token: 0x060063D2 RID: 25554
	// (set) Token: 0x060063D3 RID: 25555
	bool? ShowDesc { get; set; }

	// Token: 0x17000C31 RID: 3121
	// (get) Token: 0x060063D4 RID: 25556
	// (set) Token: 0x060063D5 RID: 25557
	bool? ShowStar { get; set; }

	// Token: 0x17000C32 RID: 3122
	// (get) Token: 0x060063D6 RID: 25558
	// (set) Token: 0x060063D7 RID: 25559
	bool? ShowScore { get; set; }

	// Token: 0x17000C33 RID: 3123
	// (get) Token: 0x060063D8 RID: 25560
	// (set) Token: 0x060063D9 RID: 25561
	bool? ShowReward { get; set; }

	// Token: 0x17000C34 RID: 3124
	// (get) Token: 0x060063DA RID: 25562
	// (set) Token: 0x060063DB RID: 25563
	int? RewardDropId { get; set; }

	// Token: 0x17000C35 RID: 3125
	// (get) Token: 0x060063DC RID: 25564
	// (set) Token: 0x060063DD RID: 25565
	bool? RewardReceived { get; set; }

	// Token: 0x17000C36 RID: 3126
	// (get) Token: 0x060063DE RID: 25566
	// (set) Token: 0x060063DF RID: 25567
	string RewardClearTitle { get; set; }
}
