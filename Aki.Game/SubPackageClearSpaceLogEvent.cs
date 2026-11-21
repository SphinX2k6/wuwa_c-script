using System;
using System.Runtime.CompilerServices;

// Token: 0x02001614 RID: 5652
[NullableContext(1)]
[Nullable(0)]
public class SubPackageClearSpaceLogEvent : CommonLogData
{
	// Token: 0x17001510 RID: 5392
	// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x004183DA File Offset: 0x004165DA
	// (set) Token: 0x0600DE64 RID: 56932 RVA: 0x004183E2 File Offset: 0x004165E2
	public override string event_id { get; set; } = "1710";

	// Token: 0x04007E7C RID: 32380
	public int i_task_id;

	// Token: 0x04007E7D RID: 32381
	public bool b_if_storage_alert;

	// Token: 0x04007E7E RID: 32382
	public int i_required_space;
}
