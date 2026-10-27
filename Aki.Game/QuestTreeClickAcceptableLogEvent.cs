using System;
using System.Runtime.CompilerServices;

// Token: 0x02002133 RID: 8499
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeClickAcceptableLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D9 RID: 5337
	// (get) Token: 0x060109D5 RID: 68053 RVA: 0x0040BB22 File Offset: 0x00409D22
	// (set) Token: 0x060109D6 RID: 68054 RVA: 0x0040BB2A File Offset: 0x00409D2A
	public override string event_id { get; set; } = "1917";

	// Token: 0x04007D41 RID: 32065
	public int i_chapter_id;
}
