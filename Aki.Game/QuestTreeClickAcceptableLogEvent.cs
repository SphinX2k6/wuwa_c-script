using System;
using System.Runtime.CompilerServices;

// Token: 0x0200160B RID: 5643
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeClickAcceptableLogEvent : PlayerCommonLogData
{
	// Token: 0x17001507 RID: 5383
	// (get) Token: 0x0600DE48 RID: 56904 RVA: 0x0041826A File Offset: 0x0041646A
	// (set) Token: 0x0600DE49 RID: 56905 RVA: 0x00418272 File Offset: 0x00416472
	public override string event_id { get; set; } = "1917";

	// Token: 0x04007E51 RID: 32337
	public int i_chapter_id;
}
