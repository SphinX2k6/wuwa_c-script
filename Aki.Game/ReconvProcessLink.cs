using System;
using System.Runtime.CompilerServices;

// Token: 0x020020CB RID: 8395
[NullableContext(1)]
[Nullable(0)]
public class ReconvProcessLink : CommonLogData
{
	// Token: 0x17001475 RID: 5237
	// (get) Token: 0x060108A2 RID: 67746 RVA: 0x0040A843 File Offset: 0x00408A43
	// (set) Token: 0x060108A3 RID: 67747 RVA: 0x0040A84B File Offset: 0x00408A4B
	public override string event_id { get; set; } = "18001";

	// Token: 0x04007B38 RID: 31544
	public string s_trace_id = "";

	// Token: 0x04007B39 RID: 31545
	public string s_player_id = "";

	// Token: 0x04007B3A RID: 31546
	public string s_user_id = "";

	// Token: 0x04007B3B RID: 31547
	public string s_user_name = "";

	// Token: 0x04007B3C RID: 31548
	public string s_reconv_step = "";

	// Token: 0x04007B3D RID: 31549
	public string s_app_version = "";

	// Token: 0x04007B3E RID: 31550
	public string s_launcher_version = "";

	// Token: 0x04007B3F RID: 31551
	public string s_resource_version = "";

	// Token: 0x04007B40 RID: 31552
	public string s_client_version = "";

	// Token: 0x04007B41 RID: 31553
	public int i_error_code;
}
