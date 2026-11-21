using System;

// Token: 0x02000D7D RID: 3453
public interface IItemInteractionPanelItemInfo
{
	// Token: 0x17000F87 RID: 3975
	// (get) Token: 0x06008DEA RID: 36330
	// (set) Token: 0x06008DEB RID: 36331
	int ItemConfigId { get; set; }

	// Token: 0x17000F88 RID: 3976
	// (get) Token: 0x06008DEC RID: 36332
	// (set) Token: 0x06008DED RID: 36333
	int CurrentCount { get; set; }

	// Token: 0x17000F89 RID: 3977
	// (get) Token: 0x06008DEE RID: 36334
	// (set) Token: 0x06008DEF RID: 36335
	int? NeedCount { get; set; }
}
