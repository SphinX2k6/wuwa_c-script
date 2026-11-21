using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001641 RID: 5697
[NullableContext(1)]
[Nullable(0)]
public class SheriffReasoningCompleteEvent : PlayerCommonLogData
{
	// Token: 0x17001539 RID: 5433
	// (get) Token: 0x0600DEE2 RID: 57058 RVA: 0x00418AFC File Offset: 0x00416CFC
	// (set) Token: 0x0600DEE3 RID: 57059 RVA: 0x00418B04 File Offset: 0x00416D04
	public override string event_id { get; set; } = "1920";

	// Token: 0x04007F63 RID: 32611
	public int i_quest_id;

	// Token: 0x04007F64 RID: 32612
	public int i_question_id;

	// Token: 0x04007F65 RID: 32613
	public int i_result_id;

	// Token: 0x04007F66 RID: 32614
	[Nullable(2)]
	public List<int> o_clue_id;
}
