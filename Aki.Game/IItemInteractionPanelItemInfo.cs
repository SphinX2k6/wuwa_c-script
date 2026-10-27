using System;

// Token: 0x020018C4 RID: 6340
public interface IItemInteractionPanelItemInfo
{
	// Token: 0x17000F64 RID: 3940
	// (get) Token: 0x0600BA01 RID: 47617
	// (set) Token: 0x0600BA02 RID: 47618
	int ItemConfigId { get; set; }

	// Token: 0x17000F65 RID: 3941
	// (get) Token: 0x0600BA03 RID: 47619
	// (set) Token: 0x0600BA04 RID: 47620
	int CurrentCount { get; set; }

	// Token: 0x17000F66 RID: 3942
	// (get) Token: 0x0600BA05 RID: 47621
	// (set) Token: 0x0600BA06 RID: 47622
	int? NeedCount { get; set; }
}
