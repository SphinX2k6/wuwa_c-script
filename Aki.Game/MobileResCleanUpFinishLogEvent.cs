using System;
using System.Runtime.CompilerServices;

// Token: 0x02002141 RID: 8513
[NullableContext(1)]
[Nullable(0)]
public class MobileResCleanUpFinishLogEvent : CommonLogData
{
	// Token: 0x170014E6 RID: 5350
	// (get) Token: 0x060109FD RID: 68093 RVA: 0x0040BD77 File Offset: 0x00409F77
	// (set) Token: 0x060109FE RID: 68094 RVA: 0x0040BD7F File Offset: 0x00409F7F
	public override string event_id { get; set; } = "1714";

	// Token: 0x04007D84 RID: 32132
	public string s_trace_id = "";

	// Token: 0x04007D85 RID: 32133
	public string unique_id = "";

	// Token: 0x04007D86 RID: 32134
	public string player_id = "";
}
