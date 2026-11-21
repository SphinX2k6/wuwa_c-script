using System;

// Token: 0x02001D64 RID: 7524
public interface IDropRewardItemData : IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001BD5 RID: 7125
	// (get) Token: 0x0601299C RID: 76188
	// (set) Token: 0x0601299D RID: 76189
	int ItemId { get; set; }

	// Token: 0x17001BD6 RID: 7126
	// (get) Token: 0x0601299E RID: 76190
	// (set) Token: 0x0601299F RID: 76191
	int Count { get; set; }

	// Token: 0x17001BD7 RID: 7127
	// (get) Token: 0x060129A0 RID: 76192
	// (set) Token: 0x060129A1 RID: 76193
	bool HaveFinish { get; set; }
}
