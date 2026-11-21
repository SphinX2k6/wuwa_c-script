using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020015A1 RID: 5537
[NullableContext(1)]
[Nullable(0)]
public class LoginProcessLink : CommonLogData
{
	// Token: 0x170014A1 RID: 5281
	// (get) Token: 0x0600DD0F RID: 56591 RVA: 0x00416E48 File Offset: 0x00415048
	// (set) Token: 0x0600DD10 RID: 56592 RVA: 0x00416E50 File Offset: 0x00415050
	public override string event_id { get; set; } = "18000";

	// Token: 0x04007C1C RID: 31772
	public string s_trace_id = "";

	// Token: 0x04007C1D RID: 31773
	public string s_user_id = "";

	// Token: 0x04007C1E RID: 31774
	public string s_user_name = "";

	// Token: 0x04007C1F RID: 31775
	public string s_login_step = "";

	// Token: 0x04007C20 RID: 31776
	public string s_app_version = "";

	// Token: 0x04007C21 RID: 31777
	public string s_launcher_version = "";

	// Token: 0x04007C22 RID: 31778
	public string s_resource_version = "";

	// Token: 0x04007C23 RID: 31779
	public string s_client_version = "";

	// Token: 0x04007C24 RID: 31780
	public int i_error_code;

	// Token: 0x04007C25 RID: 31781
	public string s_cpu_info = "";

	// Token: 0x04007C26 RID: 31782
	public string s_device_info = "";

	// Token: 0x04007C27 RID: 31783
	public string s_driver_date = "";

	// Token: 0x04007C28 RID: 31784
	public string s_device_id = "";

	// Token: 0x04007C29 RID: 31785
	public string s_command_line = "";

	// Token: 0x04007C2A RID: 31786
	public string s_os = "";

	// Token: 0x04007C2B RID: 31787
	public string s_os_version = "";

	// Token: 0x04007C2C RID: 31788
	public List<KuroConfigMonitorData> o_ini_info;

	// Token: 0x04007C2D RID: 31789
	public string s_selected_udp_host = "";

	// Token: 0x04007C2E RID: 31790
	public bool b_udp_host_pick_by_detection;

	// Token: 0x04007C2F RID: 31791
	public int i_connect_family;

	// Token: 0x04007C30 RID: 31792
	public int i_udp_port;

	// Token: 0x04007C31 RID: 31793
	public string s_resolved_ip = "";

	// Token: 0x04007C32 RID: 31794
	public string s_ping_results = "";

	// Token: 0x04007C33 RID: 31795
	public string s_ping_gar_results = "";

	// Token: 0x04007C34 RID: 31796
	public int s_quality_version;
}
