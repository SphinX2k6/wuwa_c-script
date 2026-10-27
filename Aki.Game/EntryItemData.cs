using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B0E RID: 11022
[NullableContext(1)]
[Nullable(0)]
public class EntryItemData : IEntryItemData
{
	// Token: 0x17001E99 RID: 7833
	// (get) Token: 0x06016E8C RID: 93836 RVA: 0x005D0206 File Offset: 0x005CE406
	// (set) Token: 0x06016E8D RID: 93837 RVA: 0x005D020E File Offset: 0x005CE40E
	public string Text { get; set; } = "";

	// Token: 0x17001E9A RID: 7834
	// (get) Token: 0x06016E8E RID: 93838 RVA: 0x005D0217 File Offset: 0x005CE417
	// (set) Token: 0x06016E8F RID: 93839 RVA: 0x005D021F File Offset: 0x005CE41F
	public string[] Args { get; set; } = Array.Empty<string>();

	// Token: 0x17001E9B RID: 7835
	// (get) Token: 0x06016E90 RID: 93840 RVA: 0x005D0228 File Offset: 0x005CE428
	// (set) Token: 0x06016E91 RID: 93841 RVA: 0x005D0230 File Offset: 0x005CE430
	public string Color { get; set; } = "";
}
