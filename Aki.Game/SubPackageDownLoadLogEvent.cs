using System;
using System.Runtime.CompilerServices;

// Token: 0x0200213A RID: 8506
[NullableContext(1)]
[Nullable(0)]
public class SubPackageDownLoadLogEvent : CommonLogData
{
	// Token: 0x170014E0 RID: 5344
	// (get) Token: 0x060109EA RID: 68074 RVA: 0x0040BC34 File Offset: 0x00409E34
	// (set) Token: 0x060109EB RID: 68075 RVA: 0x0040BC3C File Offset: 0x00409E3C
	public override string event_id { get; set; } = "1706";

	// Token: 0x04007D5B RID: 32091
	public string s_suit_name = "";

	// Token: 0x04007D5C RID: 32092
	public bool b_if_storage_alert;

	// Token: 0x04007D5D RID: 32093
	public int i_peak_speed;

	// Token: 0x04007D5E RID: 32094
	public int i_download_time;

	// Token: 0x04007D5F RID: 32095
	public int i_download_status;

	// Token: 0x04007D60 RID: 32096
	public int i_resource_type;

	// Token: 0x04007D61 RID: 32097
	public int i_resource_size;

	// Token: 0x04007D62 RID: 32098
	public int i_state;

	// Token: 0x04007D63 RID: 32099
	public int i_role_id;
}
