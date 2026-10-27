using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020CA RID: 8394
[NullableContext(1)]
[Nullable(0)]
public class LoginProcessLink : CommonLogData
{
	// Token: 0x17001474 RID: 5236
	// (get) Token: 0x0601089F RID: 67743 RVA: 0x0040A740 File Offset: 0x00408940
	// (set) Token: 0x060108A0 RID: 67744 RVA: 0x0040A748 File Offset: 0x00408948
	public override string event_id { get; set; } = "18000";

	// Token: 0x04007B1E RID: 31518
	public string s_trace_id = "";

	// Token: 0x04007B1F RID: 31519
	public string s_user_id = "";

	// Token: 0x04007B20 RID: 31520
	public string s_user_name = "";

	// Token: 0x04007B21 RID: 31521
	public string s_login_step = "";

	// Token: 0x04007B22 RID: 31522
	public string s_app_version = "";

	// Token: 0x04007B23 RID: 31523
	public string s_launcher_version = "";

	// Token: 0x04007B24 RID: 31524
	public string s_resource_version = "";

	// Token: 0x04007B25 RID: 31525
	public string s_client_version = "";

	// Token: 0x04007B26 RID: 31526
	public int i_error_code;

	// Token: 0x04007B27 RID: 31527
	public string s_cpu_info = "";

	// Token: 0x04007B28 RID: 31528
	public string s_device_info = "";

	// Token: 0x04007B29 RID: 31529
	public string s_driver_date = "";

	// Token: 0x04007B2A RID: 31530
	public string s_device_id = "";

	// Token: 0x04007B2B RID: 31531
	public string s_command_line = "";

	// Token: 0x04007B2C RID: 31532
	public string s_os = "";

	// Token: 0x04007B2D RID: 31533
	public string s_os_version = "";

	// Token: 0x04007B2E RID: 31534
	public List<KuroConfigMonitorData> o_ini_info;

	// Token: 0x04007B2F RID: 31535
	public string s_selected_udp_host = "";

	// Token: 0x04007B30 RID: 31536
	public bool b_udp_host_pick_by_detection;

	// Token: 0x04007B31 RID: 31537
	public int i_connect_family;

	// Token: 0x04007B32 RID: 31538
	public int i_udp_port;

	// Token: 0x04007B33 RID: 31539
	public string s_resolved_ip = "";

	// Token: 0x04007B34 RID: 31540
	public string s_ping_results = "";

	// Token: 0x04007B35 RID: 31541
	public string s_ping_gar_results = "";

	// Token: 0x04007B36 RID: 31542
	public int s_quality_version;
}
