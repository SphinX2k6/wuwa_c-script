using System;

// Token: 0x02000699 RID: 1689
public interface ICollectionQuestState
{
	// Token: 0x17000A8C RID: 2700
	// (get) Token: 0x06004DC2 RID: 19906
	// (set) Token: 0x06004DC3 RID: 19907
	int QuestState { get; set; }

	// Token: 0x17000A8D RID: 2701
	// (get) Token: 0x06004DC4 RID: 19908
	// (set) Token: 0x06004DC5 RID: 19909
	bool ClaimedReward { get; set; }

	// Token: 0x17000A8E RID: 2702
	// (get) Token: 0x06004DC6 RID: 19910
	// (set) Token: 0x06004DC7 RID: 19911
	long QuestUnlockStamp { get; set; }
}
