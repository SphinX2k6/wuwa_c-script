using System;

// Token: 0x020027E9 RID: 10217
public interface IDropRewardItemData : IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001B7D RID: 7037
	// (get) Token: 0x06014F9C RID: 85916
	// (set) Token: 0x06014F9D RID: 85917
	int ItemId { get; set; }

	// Token: 0x17001B7E RID: 7038
	// (get) Token: 0x06014F9E RID: 85918
	// (set) Token: 0x06014F9F RID: 85919
	int Count { get; set; }

	// Token: 0x17001B7F RID: 7039
	// (get) Token: 0x06014FA0 RID: 85920
	// (set) Token: 0x06014FA1 RID: 85921
	bool HaveFinish { get; set; }
}
