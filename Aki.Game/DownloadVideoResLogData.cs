using System;
using System.Runtime.CompilerServices;

// Token: 0x02002106 RID: 8454
[NullableContext(1)]
[Nullable(0)]
public class DownloadVideoResLogData : CommonLogData
{
	// Token: 0x170014AC RID: 5292
	// (get) Token: 0x0601094E RID: 67918 RVA: 0x0040B2FC File Offset: 0x004094FC
	// (set) Token: 0x0601094F RID: 67919 RVA: 0x0040B304 File Offset: 0x00409504
	public override string event_id { get; set; } = "1701";

	// Token: 0x04007C75 RID: 31861
	public int i_task_id;

	// Token: 0x04007C76 RID: 31862
	public bool b_if_storage_alert;

	// Token: 0x04007C77 RID: 31863
	public int i_peak_speed;

	// Token: 0x04007C78 RID: 31864
	public int i_download_time;

	// Token: 0x04007C79 RID: 31865
	public int i_download_status;

	// Token: 0x04007C7A RID: 31866
	public int i_role_id;

	// Token: 0x04007C7B RID: 31867
	public int i_resource_type;

	// Token: 0x04007C7C RID: 31868
	public double i_resource_size;
}
