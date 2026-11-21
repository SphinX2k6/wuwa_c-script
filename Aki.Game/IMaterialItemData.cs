using System;

// Token: 0x02001D62 RID: 7522
public interface IMaterialItemData : IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001BD0 RID: 7120
	// (get) Token: 0x06012991 RID: 76177
	// (set) Token: 0x06012992 RID: 76178
	int ItemId { get; set; }

	// Token: 0x17001BD1 RID: 7121
	// (get) Token: 0x06012993 RID: 76179
	// (set) Token: 0x06012994 RID: 76180
	int RequiredCount { get; set; }
}
