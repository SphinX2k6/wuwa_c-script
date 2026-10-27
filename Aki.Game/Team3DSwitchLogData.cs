using System;
using System.Runtime.CompilerServices;

// Token: 0x0200217E RID: 8574
[NullableContext(1)]
[Nullable(0)]
public class Team3DSwitchLogData : PlayerCommonLogData
{
	// Token: 0x1700151D RID: 5405
	// (get) Token: 0x06010AA8 RID: 68264 RVA: 0x0040C6E0 File Offset: 0x0040A8E0
	// (set) Token: 0x06010AA9 RID: 68265 RVA: 0x0040C6E8 File Offset: 0x0040A8E8
	public override string event_id { get; set; } = "1939";

	// Token: 0x04007EC0 RID: 32448
	public int i_type;

	// Token: 0x04007EC1 RID: 32449
	public int i_formation_id;

	// Token: 0x04007EC2 RID: 32450
	public int i_cost_time;

	// Token: 0x04007EC3 RID: 32451
	public int i_use_time;

	// Token: 0x04007EC4 RID: 32452
	public string s_roles = string.Empty;
}
