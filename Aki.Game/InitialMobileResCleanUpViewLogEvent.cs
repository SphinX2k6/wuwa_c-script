using System;
using System.Runtime.CompilerServices;

// Token: 0x0200213E RID: 8510
[NullableContext(1)]
[Nullable(0)]
public class InitialMobileResCleanUpViewLogEvent : CommonLogData
{
	// Token: 0x170014E4 RID: 5348
	// (get) Token: 0x060109F6 RID: 68086 RVA: 0x0040BCDA File Offset: 0x00409EDA
	// (set) Token: 0x060109F7 RID: 68087 RVA: 0x0040BCE2 File Offset: 0x00409EE2
	public override string event_id { get; set; } = "1712";

	// Token: 0x04007D75 RID: 32117
	public int i_remaining_space;

	// Token: 0x04007D76 RID: 32118
	public int i_type;

	// Token: 0x04007D77 RID: 32119
	public string s_trace_id = "";

	// Token: 0x04007D78 RID: 32120
	public string unique_id = "";

	// Token: 0x04007D79 RID: 32121
	public string player_id = "";
}
