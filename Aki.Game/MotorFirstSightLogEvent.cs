using System;
using System.Runtime.CompilerServices;

// Token: 0x0200211E RID: 8478
[NullableContext(1)]
[Nullable(0)]
public class MotorFirstSightLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C4 RID: 5316
	// (get) Token: 0x06010996 RID: 67990 RVA: 0x0040B818 File Offset: 0x00409A18
	// (set) Token: 0x06010997 RID: 67991 RVA: 0x0040B820 File Offset: 0x00409A20
	public override string event_id { get; set; } = "2001";

	// Token: 0x04007CF8 RID: 31992
	public float i_view_switching;
}
