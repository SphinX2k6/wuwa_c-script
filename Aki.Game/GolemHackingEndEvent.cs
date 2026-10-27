using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002166 RID: 8550
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingEndEvent : PlayerCommonLogData
{
	// Token: 0x17001508 RID: 5384
	// (get) Token: 0x06010A66 RID: 68198 RVA: 0x0040C33D File Offset: 0x0040A53D
	// (set) Token: 0x06010A67 RID: 68199 RVA: 0x0040C345 File Offset: 0x0040A545
	public override string event_id { get; set; } = "1922";

	// Token: 0x04007E42 RID: 32322
	public int i_id;

	// Token: 0x04007E43 RID: 32323
	public int i_first_pass;

	// Token: 0x04007E44 RID: 32324
	public int i_result;

	// Token: 0x04007E45 RID: 32325
	public int i_pass_time;

	// Token: 0x04007E46 RID: 32326
	public int i_total_duration;

	// Token: 0x04007E47 RID: 32327
	public string s_trace_id = "";

	// Token: 0x04007E48 RID: 32328
	[Nullable(2)]
	public List<int> o_path;

	// Token: 0x04007E49 RID: 32329
	public int i_count;

	// Token: 0x04007E4A RID: 32330
	public int i_recount;

	// Token: 0x04007E4B RID: 32331
	public int i_false_count;
}
