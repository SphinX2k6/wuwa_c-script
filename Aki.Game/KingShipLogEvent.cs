using System;
using System.Runtime.CompilerServices;

// Token: 0x02002118 RID: 8472
[NullableContext(1)]
[Nullable(0)]
public class KingShipLogEvent : PlayerCommonLogData
{
	// Token: 0x170014BE RID: 5310
	// (get) Token: 0x06010984 RID: 67972 RVA: 0x0040B71F File Offset: 0x0040991F
	// (set) Token: 0x06010985 RID: 67973 RVA: 0x0040B727 File Offset: 0x00409927
	public override string event_id { get; set; } = "1801";

	// Token: 0x04007CED RID: 31981
	public int i_step_id;
}
