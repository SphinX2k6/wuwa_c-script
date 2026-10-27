using System;

// Token: 0x02001407 RID: 5127
public interface IPinballItemDataItem
{
	// Token: 0x17000C54 RID: 3156
	// (get) Token: 0x060090E8 RID: 37096
	// (set) Token: 0x060090E9 RID: 37097
	EPinballItemType Type { get; set; }

	// Token: 0x17000C55 RID: 3157
	// (get) Token: 0x060090EA RID: 37098
	// (set) Token: 0x060090EB RID: 37099
	TItem Item { get; set; }
}
