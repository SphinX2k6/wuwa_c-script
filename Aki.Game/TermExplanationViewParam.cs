using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002BA3 RID: 11171
[NullableContext(1)]
[Nullable(0)]
public class TermExplanationViewParam : ITermExplanationViewParam
{
	// Token: 0x17001F30 RID: 7984
	// (get) Token: 0x0601723C RID: 94780 RVA: 0x005DE31F File Offset: 0x005DC51F
	// (set) Token: 0x0601723D RID: 94781 RVA: 0x005DE327 File Offset: 0x005DC527
	public List<string> HyperLinkList { get; set; } = new List<string>();

	// Token: 0x17001F31 RID: 7985
	// (get) Token: 0x0601723E RID: 94782 RVA: 0x005DE330 File Offset: 0x005DC530
	// (set) Token: 0x0601723F RID: 94783 RVA: 0x005DE338 File Offset: 0x005DC538
	[Nullable(2)]
	public string FocusedHyperLink { [NullableContext(2)] get; [NullableContext(2)] set; }
}
