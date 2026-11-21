using System;

// Token: 0x020008DC RID: 2268
public class PinballItemDataItem : IPinballItemDataItem
{
	// Token: 0x17000CCC RID: 3276
	// (get) Token: 0x06006538 RID: 25912 RVA: 0x001FBB0E File Offset: 0x001F9D0E
	// (set) Token: 0x06006539 RID: 25913 RVA: 0x001FBB16 File Offset: 0x001F9D16
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CCD RID: 3277
	// (get) Token: 0x0600653A RID: 25914 RVA: 0x001FBB1F File Offset: 0x001F9D1F
	// (set) Token: 0x0600653B RID: 25915 RVA: 0x001FBB27 File Offset: 0x001F9D27
	public TItem Item { get; set; }
}
