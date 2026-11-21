using System;
using System.Runtime.CompilerServices;

// Token: 0x0200165C RID: 5724
[NullableContext(1)]
[Nullable(0)]
public class AdventureGuideBtnClickLogEvent : PlayerCommonLogData
{
	// Token: 0x17001550 RID: 5456
	// (get) Token: 0x0600DF2B RID: 57131 RVA: 0x00418F26 File Offset: 0x00417126
	// (set) Token: 0x0600DF2C RID: 57132 RVA: 0x00418F2E File Offset: 0x0041712E
	public override string event_id { get; set; } = "2008";

	// Token: 0x04008002 RID: 32770
	public int i_btn_type;

	// Token: 0x04008003 RID: 32771
	public int i_type;

	// Token: 0x04008004 RID: 32772
	public int i_inst_id;

	// Token: 0x04008005 RID: 32773
	public int i_inst_sub_type;
}
