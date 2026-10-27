using System;
using System.Runtime.CompilerServices;

// Token: 0x0200213D RID: 8509
[NullableContext(1)]
[Nullable(0)]
public class SubPackageClearSpaceFinishLogEvent : CommonLogData
{
	// Token: 0x170014E3 RID: 5347
	// (get) Token: 0x060109F3 RID: 68083 RVA: 0x0040BCB6 File Offset: 0x00409EB6
	// (set) Token: 0x060109F4 RID: 68084 RVA: 0x0040BCBE File Offset: 0x00409EBE
	public override string event_id { get; set; } = "1711";

	// Token: 0x04007D70 RID: 32112
	public int i_task_id;

	// Token: 0x04007D71 RID: 32113
	public int i_required_space;

	// Token: 0x04007D72 RID: 32114
	public int i_remaining_space;

	// Token: 0x04007D73 RID: 32115
	public bool b_if_storage_alert;
}
