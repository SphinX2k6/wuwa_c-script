using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014E9 RID: 5353
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketRoundResult : IScratchTicketRoundResult
{
	// Token: 0x17000D27 RID: 3367
	// (get) Token: 0x0600985A RID: 39002 RVA: 0x0020E926 File Offset: 0x0020CB26
	// (set) Token: 0x0600985B RID: 39003 RVA: 0x0020E92E File Offset: 0x0020CB2E
	public List<ScratchTicketRewardResult> RewardList { get; set; }

	// Token: 0x17000D28 RID: 3368
	// (get) Token: 0x0600985C RID: 39004 RVA: 0x0020E937 File Offset: 0x0020CB37
	// (set) Token: 0x0600985D RID: 39005 RVA: 0x0020E93F File Offset: 0x0020CB3F
	public float DelayInterval { get; set; }

	// Token: 0x17000D29 RID: 3369
	// (get) Token: 0x0600985E RID: 39006 RVA: 0x0020E948 File Offset: 0x0020CB48
	// (set) Token: 0x0600985F RID: 39007 RVA: 0x0020E950 File Offset: 0x0020CB50
	public string SequenceName { get; set; }
}
