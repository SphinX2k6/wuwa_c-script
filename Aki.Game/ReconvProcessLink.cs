using System;
using System.Runtime.CompilerServices;

// Token: 0x020015A2 RID: 5538
[NullableContext(1)]
[Nullable(0)]
public class ReconvProcessLink : CommonLogData
{
	// Token: 0x170014A2 RID: 5282
	// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x00416F4B File Offset: 0x0041514B
	// (set) Token: 0x0600DD13 RID: 56595 RVA: 0x00416F53 File Offset: 0x00415153
	public override string event_id { get; set; } = "18001";

	// Token: 0x04007C36 RID: 31798
	public string s_trace_id = "";

	// Token: 0x04007C37 RID: 31799
	public string s_player_id = "";

	// Token: 0x04007C38 RID: 31800
	public string s_user_id = "";

	// Token: 0x04007C39 RID: 31801
	public string s_user_name = "";

	// Token: 0x04007C3A RID: 31802
	public string s_reconv_step = "";

	// Token: 0x04007C3B RID: 31803
	public string s_app_version = "";

	// Token: 0x04007C3C RID: 31804
	public string s_launcher_version = "";

	// Token: 0x04007C3D RID: 31805
	public string s_resource_version = "";

	// Token: 0x04007C3E RID: 31806
	public string s_client_version = "";

	// Token: 0x04007C3F RID: 31807
	public int i_error_code;
}
