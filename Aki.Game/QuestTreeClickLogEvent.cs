using System;
using System.Runtime.CompilerServices;

// Token: 0x02002131 RID: 8497
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeClickLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D7 RID: 5335
	// (get) Token: 0x060109CF RID: 68047 RVA: 0x0040BADA File Offset: 0x00409CDA
	// (set) Token: 0x060109D0 RID: 68048 RVA: 0x0040BAE2 File Offset: 0x00409CE2
	public override string event_id { get; set; } = "1912";

	// Token: 0x04007D36 RID: 32054
	public int i_chapter_id;

	// Token: 0x04007D37 RID: 32055
	public int i_quest_id;

	// Token: 0x04007D38 RID: 32056
	public int i_quest_status;

	// Token: 0x04007D39 RID: 32057
	public int i_quest_type;
}
