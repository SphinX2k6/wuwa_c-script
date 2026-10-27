using System;

// Token: 0x020027E7 RID: 10215
public interface IMaterialItemData : IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001B78 RID: 7032
	// (get) Token: 0x06014F91 RID: 85905
	// (set) Token: 0x06014F92 RID: 85906
	int ItemId { get; set; }

	// Token: 0x17001B79 RID: 7033
	// (get) Token: 0x06014F93 RID: 85907
	// (set) Token: 0x06014F94 RID: 85908
	int RequiredCount { get; set; }
}
