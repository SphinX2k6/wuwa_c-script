using System;
using System.Runtime.CompilerServices;

// Token: 0x02002142 RID: 8514
[NullableContext(1)]
[Nullable(0)]
public class RecallDownLoadDialogLogEvent : CommonLogData
{
	// Token: 0x170014E7 RID: 5351
	// (get) Token: 0x06010A00 RID: 68096 RVA: 0x0040BDBC File Offset: 0x00409FBC
	// (set) Token: 0x06010A01 RID: 68097 RVA: 0x0040BDC4 File Offset: 0x00409FC4
	public override string event_id { get; set; } = "1716";

	// Token: 0x04007D88 RID: 32136
	public int i_recall_id;

	// Token: 0x04007D89 RID: 32137
	public bool b_if_storage_alert;

	// Token: 0x04007D8A RID: 32138
	public int i_required_space;

	// Token: 0x04007D8B RID: 32139
	public int i_remaining_space;

	// Token: 0x04007D8C RID: 32140
	public string s_trace_id = "";
}
