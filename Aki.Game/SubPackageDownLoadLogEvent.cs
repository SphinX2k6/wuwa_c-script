using System;
using System.Runtime.CompilerServices;

// Token: 0x02001612 RID: 5650
[NullableContext(1)]
[Nullable(0)]
public class SubPackageDownLoadLogEvent : CommonLogData
{
	// Token: 0x1700150E RID: 5390
	// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x0041837C File Offset: 0x0041657C
	// (set) Token: 0x0600DE5E RID: 56926 RVA: 0x00418384 File Offset: 0x00416584
	public override string event_id { get; set; } = "1706";

	// Token: 0x04007E6B RID: 32363
	public string s_suit_name = "";

	// Token: 0x04007E6C RID: 32364
	public bool b_if_storage_alert;

	// Token: 0x04007E6D RID: 32365
	public int i_peak_speed;

	// Token: 0x04007E6E RID: 32366
	public int i_download_time;

	// Token: 0x04007E6F RID: 32367
	public int i_download_status;

	// Token: 0x04007E70 RID: 32368
	public int i_resource_type;

	// Token: 0x04007E71 RID: 32369
	public int i_resource_size;

	// Token: 0x04007E72 RID: 32370
	public int i_state;

	// Token: 0x04007E73 RID: 32371
	public int i_role_id;
}
