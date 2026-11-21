using System;
using System.Runtime.CompilerServices;

// Token: 0x02001615 RID: 5653
[NullableContext(1)]
[Nullable(0)]
public class SubPackageClearSpaceFinishLogEvent : CommonLogData
{
	// Token: 0x17001511 RID: 5393
	// (get) Token: 0x0600DE66 RID: 56934 RVA: 0x004183FE File Offset: 0x004165FE
	// (set) Token: 0x0600DE67 RID: 56935 RVA: 0x00418406 File Offset: 0x00416606
	public override string event_id { get; set; } = "1711";

	// Token: 0x04007E80 RID: 32384
	public int i_task_id;

	// Token: 0x04007E81 RID: 32385
	public int i_required_space;

	// Token: 0x04007E82 RID: 32386
	public int i_remaining_space;

	// Token: 0x04007E83 RID: 32387
	public bool b_if_storage_alert;
}
