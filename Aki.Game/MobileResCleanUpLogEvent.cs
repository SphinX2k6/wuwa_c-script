using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002140 RID: 8512
[NullableContext(1)]
[Nullable(0)]
public class MobileResCleanUpLogEvent : CommonLogData
{
	// Token: 0x170014E5 RID: 5349
	// (get) Token: 0x060109FA RID: 68090 RVA: 0x0040BD27 File Offset: 0x00409F27
	// (set) Token: 0x060109FB RID: 68091 RVA: 0x0040BD2F File Offset: 0x00409F2F
	public override string event_id { get; set; } = "1713";

	// Token: 0x04007D7D RID: 32125
	public int i_required_space;

	// Token: 0x04007D7E RID: 32126
	public List<MobileResCleanUpLogEventContentData> o_content = new List<MobileResCleanUpLogEventContentData>();

	// Token: 0x04007D7F RID: 32127
	public int i_type;

	// Token: 0x04007D80 RID: 32128
	public string s_trace_id = "";

	// Token: 0x04007D81 RID: 32129
	public string unique_id = "";

	// Token: 0x04007D82 RID: 32130
	public string player_id = "";
}
