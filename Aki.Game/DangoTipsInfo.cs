using System;
using System.Runtime.CompilerServices;

// Token: 0x02001237 RID: 4663
[NullableContext(1)]
[Nullable(0)]
public class DangoTipsInfo : IDangoTipsInfo
{
	// Token: 0x17000ABA RID: 2746
	// (get) Token: 0x06007E0B RID: 32267 RVA: 0x001AAEB4 File Offset: 0x001A90B4
	// (set) Token: 0x06007E0C RID: 32268 RVA: 0x001AAEBC File Offset: 0x001A90BC
	public string Text { get; set; } = "";

	// Token: 0x17000ABB RID: 2747
	// (get) Token: 0x06007E0D RID: 32269 RVA: 0x001AAEC5 File Offset: 0x001A90C5
	// (set) Token: 0x06007E0E RID: 32270 RVA: 0x001AAECD File Offset: 0x001A90CD
	[Nullable(2)]
	public string Icon { [NullableContext(2)] get; [NullableContext(2)] set; } = "";
}
