using System;

// Token: 0x020011E6 RID: 4582
public class CollectionQuestState : ICollectionQuestState
{
	// Token: 0x17000A6F RID: 2671
	// (get) Token: 0x06007A31 RID: 31281 RVA: 0x0019B5F4 File Offset: 0x001997F4
	// (set) Token: 0x06007A32 RID: 31282 RVA: 0x0019B5FC File Offset: 0x001997FC
	public int QuestState { get; set; }

	// Token: 0x17000A70 RID: 2672
	// (get) Token: 0x06007A33 RID: 31283 RVA: 0x0019B605 File Offset: 0x00199805
	// (set) Token: 0x06007A34 RID: 31284 RVA: 0x0019B60D File Offset: 0x0019980D
	public bool ClaimedReward { get; set; }

	// Token: 0x17000A71 RID: 2673
	// (get) Token: 0x06007A35 RID: 31285 RVA: 0x0019B616 File Offset: 0x00199816
	// (set) Token: 0x06007A36 RID: 31286 RVA: 0x0019B61E File Offset: 0x0019981E
	public long QuestUnlockStamp { get; set; }
}
