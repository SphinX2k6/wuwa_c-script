using System;
using System.Runtime.CompilerServices;

// Token: 0x020020DF RID: 8415
[NullableContext(1)]
[Nullable(0)]
public class ActivityTabViewOpenLogData : PlayerCommonLogData
{
	// Token: 0x17001487 RID: 5255
	// (get) Token: 0x060108DD RID: 67805 RVA: 0x0040AD2A File Offset: 0x00408F2A
	// (set) Token: 0x060108DE RID: 67806 RVA: 0x0040AD32 File Offset: 0x00408F32
	public override string event_id { get; set; } = "1020";

	// Token: 0x04007BF5 RID: 31733
	public int i_activity_id;

	// Token: 0x04007BF6 RID: 31734
	public int i_activity_type;

	// Token: 0x04007BF7 RID: 31735
	public int i_time_left;

	// Token: 0x04007BF8 RID: 31736
	public int i_unlock;

	// Token: 0x04007BF9 RID: 31737
	public int i_type;
}
