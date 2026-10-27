using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AA6 RID: 6822
[NullableContext(2)]
public interface IExplorePlayProgressItemData
{
	// Token: 0x17001092 RID: 4242
	// (get) Token: 0x0600C9F6 RID: 51702
	// (set) Token: 0x0600C9F7 RID: 51703
	EExploreType ExploreType { get; set; }

	// Token: 0x17001093 RID: 4243
	// (get) Token: 0x0600C9F8 RID: 51704
	// (set) Token: 0x0600C9F9 RID: 51705
	EPlayPointType PlayPointType { get; set; }

	// Token: 0x17001094 RID: 4244
	// (get) Token: 0x0600C9FA RID: 51706
	// (set) Token: 0x0600C9FB RID: 51707
	EPlayPointState PlayPointState { get; set; }

	// Token: 0x17001095 RID: 4245
	// (get) Token: 0x0600C9FC RID: 51708
	// (set) Token: 0x0600C9FD RID: 51709
	int? PlayPointId { get; set; }

	// Token: 0x17001096 RID: 4246
	// (get) Token: 0x0600C9FE RID: 51710
	// (set) Token: 0x0600C9FF RID: 51711
	EPlayPointState? LastPlayPointState { get; set; }

	// Token: 0x17001097 RID: 4247
	// (get) Token: 0x0600CA00 RID: 51712
	// (set) Token: 0x0600CA01 RID: 51713
	int? EntityId { get; set; }

	// Token: 0x17001098 RID: 4248
	// (get) Token: 0x0600CA02 RID: 51714
	// (set) Token: 0x0600CA03 RID: 51715
	bool? IgnoreHiddenType { get; set; }

	// Token: 0x17001099 RID: 4249
	// (get) Token: 0x0600CA04 RID: 51716
	// (set) Token: 0x0600CA05 RID: 51717
	bool? IsClear { get; set; }

	// Token: 0x1700109A RID: 4250
	// (get) Token: 0x0600CA06 RID: 51718
	// (set) Token: 0x0600CA07 RID: 51719
	string ClearInfo { get; set; }

	// Token: 0x1700109B RID: 4251
	// (get) Token: 0x0600CA08 RID: 51720
	// (set) Token: 0x0600CA09 RID: 51721
	bool? IsUnlock { get; set; }
}
