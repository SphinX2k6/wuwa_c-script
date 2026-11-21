using System;

// Token: 0x0200069A RID: 1690
public class CollectionQuestState : ICollectionQuestState
{
	// Token: 0x17000A8F RID: 2703
	// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x001A42A0 File Offset: 0x001A24A0
	// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x001A42A8 File Offset: 0x001A24A8
	public int QuestState { get; set; }

	// Token: 0x17000A90 RID: 2704
	// (get) Token: 0x06004DCA RID: 19914 RVA: 0x001A42B1 File Offset: 0x001A24B1
	// (set) Token: 0x06004DCB RID: 19915 RVA: 0x001A42B9 File Offset: 0x001A24B9
	public bool ClaimedReward { get; set; }

	// Token: 0x17000A91 RID: 2705
	// (get) Token: 0x06004DCC RID: 19916 RVA: 0x001A42C2 File Offset: 0x001A24C2
	// (set) Token: 0x06004DCD RID: 19917 RVA: 0x001A42CA File Offset: 0x001A24CA
	public long QuestUnlockStamp { get; set; }
}
