using System;
using System.Runtime.CompilerServices;

// Token: 0x0200161A RID: 5658
[NullableContext(1)]
[Nullable(0)]
public class RecallDownLoadDialogLogEvent : CommonLogData
{
	// Token: 0x17001515 RID: 5397
	// (get) Token: 0x0600DE73 RID: 56947 RVA: 0x00418504 File Offset: 0x00416704
	// (set) Token: 0x0600DE74 RID: 56948 RVA: 0x0041850C File Offset: 0x0041670C
	public override string event_id { get; set; } = "1716";

	// Token: 0x04007E98 RID: 32408
	public int i_recall_id;

	// Token: 0x04007E99 RID: 32409
	public bool b_if_storage_alert;

	// Token: 0x04007E9A RID: 32410
	public int i_required_space;

	// Token: 0x04007E9B RID: 32411
	public int i_remaining_space;

	// Token: 0x04007E9C RID: 32412
	public string s_trace_id = "";
}
