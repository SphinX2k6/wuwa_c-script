using System;
using System.Runtime.CompilerServices;

// Token: 0x020015DE RID: 5598
[NullableContext(1)]
[Nullable(0)]
public class DownloadVideoResLogData : CommonLogData
{
	// Token: 0x170014DA RID: 5338
	// (get) Token: 0x0600DDC1 RID: 56769 RVA: 0x00417A30 File Offset: 0x00415C30
	// (set) Token: 0x0600DDC2 RID: 56770 RVA: 0x00417A38 File Offset: 0x00415C38
	public override string event_id { get; set; } = "1701";

	// Token: 0x04007D77 RID: 32119
	public int i_task_id;

	// Token: 0x04007D78 RID: 32120
	public bool b_if_storage_alert;

	// Token: 0x04007D79 RID: 32121
	public int i_peak_speed;

	// Token: 0x04007D7A RID: 32122
	public int i_download_time;

	// Token: 0x04007D7B RID: 32123
	public int i_download_status;

	// Token: 0x04007D7C RID: 32124
	public int i_role_id;

	// Token: 0x04007D7D RID: 32125
	public int i_resource_type;

	// Token: 0x04007D7E RID: 32126
	public double i_resource_size;
}
