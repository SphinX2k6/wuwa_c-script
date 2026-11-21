using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200211F RID: 8479
[NullableContext(1)]
[Nullable(0)]
public class TermExplanationViewParam : ITermExplanationViewParam
{
	// Token: 0x17001F88 RID: 8072
	// (get) Token: 0x06014C6D RID: 85101 RVA: 0x0060AEF3 File Offset: 0x006090F3
	// (set) Token: 0x06014C6E RID: 85102 RVA: 0x0060AEFB File Offset: 0x006090FB
	public List<string> HyperLinkList { get; set; } = new List<string>();

	// Token: 0x17001F89 RID: 8073
	// (get) Token: 0x06014C6F RID: 85103 RVA: 0x0060AF04 File Offset: 0x00609104
	// (set) Token: 0x06014C70 RID: 85104 RVA: 0x0060AF0C File Offset: 0x0060910C
	[Nullable(2)]
	public string FocusedHyperLink { [NullableContext(2)] get; [NullableContext(2)] set; }
}
