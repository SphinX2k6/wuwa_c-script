using System;
using System.Runtime.CompilerServices;

// Token: 0x02001616 RID: 5654
[NullableContext(1)]
[Nullable(0)]
public class InitialMobileResCleanUpViewLogEvent : CommonLogData
{
	// Token: 0x17001512 RID: 5394
	// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x00418422 File Offset: 0x00416622
	// (set) Token: 0x0600DE6A RID: 56938 RVA: 0x0041842A File Offset: 0x0041662A
	public override string event_id { get; set; } = "1712";

	// Token: 0x04007E85 RID: 32389
	public int i_remaining_space;

	// Token: 0x04007E86 RID: 32390
	public int i_type;

	// Token: 0x04007E87 RID: 32391
	public string s_trace_id = "";

	// Token: 0x04007E88 RID: 32392
	public string unique_id = "";

	// Token: 0x04007E89 RID: 32393
	public string player_id = "";
}
