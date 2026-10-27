using System;

// Token: 0x02001428 RID: 5160
public class PinballItemDataItem : IPinballItemDataItem
{
	// Token: 0x17000CAC RID: 3244
	// (get) Token: 0x060091A3 RID: 37283 RVA: 0x001F2FD2 File Offset: 0x001F11D2
	// (set) Token: 0x060091A4 RID: 37284 RVA: 0x001F2FDA File Offset: 0x001F11DA
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CAD RID: 3245
	// (get) Token: 0x060091A5 RID: 37285 RVA: 0x001F2FE3 File Offset: 0x001F11E3
	// (set) Token: 0x060091A6 RID: 37286 RVA: 0x001F2FEB File Offset: 0x001F11EB
	public TItem Item { get; set; }
}
