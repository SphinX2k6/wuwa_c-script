using System;
using System.Runtime.CompilerServices;

// Token: 0x020013F1 RID: 5105
[NullableContext(2)]
public interface IPinballLevelInfoData
{
	// Token: 0x17000C0A RID: 3082
	// (get) Token: 0x06009031 RID: 36913
	// (set) Token: 0x06009032 RID: 36914
	int LevelId { get; set; }

	// Token: 0x17000C0B RID: 3083
	// (get) Token: 0x06009033 RID: 36915
	// (set) Token: 0x06009034 RID: 36916
	int RealLevelId { get; set; }

	// Token: 0x17000C0C RID: 3084
	// (get) Token: 0x06009035 RID: 36917
	// (set) Token: 0x06009036 RID: 36918
	int[] LevelStarConditionIds { get; set; }

	// Token: 0x17000C0D RID: 3085
	// (get) Token: 0x06009037 RID: 36919
	// (set) Token: 0x06009038 RID: 36920
	int? LevelScore { get; set; }

	// Token: 0x17000C0E RID: 3086
	// (get) Token: 0x06009039 RID: 36921
	// (set) Token: 0x0600903A RID: 36922
	bool? LevelLock { get; set; }

	// Token: 0x17000C0F RID: 3087
	// (get) Token: 0x0600903B RID: 36923
	// (set) Token: 0x0600903C RID: 36924
	string LevelLockTexts { get; set; }

	// Token: 0x17000C10 RID: 3088
	// (get) Token: 0x0600903D RID: 36925
	// (set) Token: 0x0600903E RID: 36926
	bool? ShowDesc { get; set; }

	// Token: 0x17000C11 RID: 3089
	// (get) Token: 0x0600903F RID: 36927
	// (set) Token: 0x06009040 RID: 36928
	bool? ShowStar { get; set; }

	// Token: 0x17000C12 RID: 3090
	// (get) Token: 0x06009041 RID: 36929
	// (set) Token: 0x06009042 RID: 36930
	bool? ShowScore { get; set; }

	// Token: 0x17000C13 RID: 3091
	// (get) Token: 0x06009043 RID: 36931
	// (set) Token: 0x06009044 RID: 36932
	bool? ShowReward { get; set; }

	// Token: 0x17000C14 RID: 3092
	// (get) Token: 0x06009045 RID: 36933
	// (set) Token: 0x06009046 RID: 36934
	int? RewardDropId { get; set; }

	// Token: 0x17000C15 RID: 3093
	// (get) Token: 0x06009047 RID: 36935
	// (set) Token: 0x06009048 RID: 36936
	bool? RewardReceived { get; set; }

	// Token: 0x17000C16 RID: 3094
	// (get) Token: 0x06009049 RID: 36937
	// (set) Token: 0x0600904A RID: 36938
	string RewardClearTitle { get; set; }
}
