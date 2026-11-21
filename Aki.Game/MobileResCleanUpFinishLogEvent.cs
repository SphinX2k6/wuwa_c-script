using System;
using System.Runtime.CompilerServices;

// Token: 0x02001619 RID: 5657
[NullableContext(1)]
[Nullable(0)]
public class MobileResCleanUpFinishLogEvent : CommonLogData
{
	// Token: 0x17001514 RID: 5396
	// (get) Token: 0x0600DE70 RID: 56944 RVA: 0x004184BF File Offset: 0x004166BF
	// (set) Token: 0x0600DE71 RID: 56945 RVA: 0x004184C7 File Offset: 0x004166C7
	public override string event_id { get; set; } = "1714";

	// Token: 0x04007E94 RID: 32404
	public string s_trace_id = "";

	// Token: 0x04007E95 RID: 32405
	public string unique_id = "";

	// Token: 0x04007E96 RID: 32406
	public string player_id = "";
}
