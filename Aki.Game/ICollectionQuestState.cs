using System;

// Token: 0x020011E5 RID: 4581
public interface ICollectionQuestState
{
	// Token: 0x17000A6C RID: 2668
	// (get) Token: 0x06007A2B RID: 31275
	// (set) Token: 0x06007A2C RID: 31276
	int QuestState { get; set; }

	// Token: 0x17000A6D RID: 2669
	// (get) Token: 0x06007A2D RID: 31277
	// (set) Token: 0x06007A2E RID: 31278
	bool ClaimedReward { get; set; }

	// Token: 0x17000A6E RID: 2670
	// (get) Token: 0x06007A2F RID: 31279
	// (set) Token: 0x06007A30 RID: 31280
	long QuestUnlockStamp { get; set; }
}
