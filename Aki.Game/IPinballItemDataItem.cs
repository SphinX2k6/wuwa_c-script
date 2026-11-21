using System;

// Token: 0x020008BB RID: 2235
public interface IPinballItemDataItem
{
	// Token: 0x17000C74 RID: 3188
	// (get) Token: 0x0600647D RID: 25725
	// (set) Token: 0x0600647E RID: 25726
	EPinballItemType Type { get; set; }

	// Token: 0x17000C75 RID: 3189
	// (get) Token: 0x0600647F RID: 25727
	// (set) Token: 0x06006480 RID: 25728
	TItem Item { get; set; }
}
