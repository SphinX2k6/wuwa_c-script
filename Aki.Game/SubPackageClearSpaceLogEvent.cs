using System;
using System.Runtime.CompilerServices;

// Token: 0x0200213C RID: 8508
[NullableContext(1)]
[Nullable(0)]
public class SubPackageClearSpaceLogEvent : CommonLogData
{
	// Token: 0x170014E2 RID: 5346
	// (get) Token: 0x060109F0 RID: 68080 RVA: 0x0040BC92 File Offset: 0x00409E92
	// (set) Token: 0x060109F1 RID: 68081 RVA: 0x0040BC9A File Offset: 0x00409E9A
	public override string event_id { get; set; } = "1710";

	// Token: 0x04007D6C RID: 32108
	public int i_task_id;

	// Token: 0x04007D6D RID: 32109
	public bool b_if_storage_alert;

	// Token: 0x04007D6E RID: 32110
	public int i_required_space;
}
