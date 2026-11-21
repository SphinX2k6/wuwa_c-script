using System;
using System.Runtime.CompilerServices;

// Token: 0x02001656 RID: 5718
[NullableContext(1)]
[Nullable(0)]
public class Team3DSwitchLogData : PlayerCommonLogData
{
	// Token: 0x1700154B RID: 5451
	// (get) Token: 0x0600DF1B RID: 57115 RVA: 0x00418E28 File Offset: 0x00417028
	// (set) Token: 0x0600DF1C RID: 57116 RVA: 0x00418E30 File Offset: 0x00417030
	public override string event_id { get; set; } = "1939";

	// Token: 0x04007FD0 RID: 32720
	public int i_type;

	// Token: 0x04007FD1 RID: 32721
	public int i_formation_id;

	// Token: 0x04007FD2 RID: 32722
	public int i_cost_time;

	// Token: 0x04007FD3 RID: 32723
	public int i_use_time;

	// Token: 0x04007FD4 RID: 32724
	public string s_roles = string.Empty;
}
