using System;
using System.Runtime.CompilerServices;

// Token: 0x020006EB RID: 1771
[NullableContext(1)]
[Nullable(0)]
public class DangoTipsInfo : IDangoTipsInfo
{
	// Token: 0x17000ADA RID: 2778
	// (get) Token: 0x060051A2 RID: 20898 RVA: 0x001B3B74 File Offset: 0x001B1D74
	// (set) Token: 0x060051A3 RID: 20899 RVA: 0x001B3B7C File Offset: 0x001B1D7C
	public string Text { get; set; } = "";

	// Token: 0x17000ADB RID: 2779
	// (get) Token: 0x060051A4 RID: 20900 RVA: 0x001B3B85 File Offset: 0x001B1D85
	// (set) Token: 0x060051A5 RID: 20901 RVA: 0x001B3B8D File Offset: 0x001B1D8D
	[Nullable(2)]
	public string Icon { [NullableContext(2)] get; [NullableContext(2)] set; } = "";
}
