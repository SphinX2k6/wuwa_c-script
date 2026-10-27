using System;
using System.Runtime.CompilerServices;

// Token: 0x0200211F RID: 8479
[NullableContext(1)]
[Nullable(0)]
public class MotorDriftLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C5 RID: 5317
	// (get) Token: 0x06010999 RID: 67993 RVA: 0x0040B83C File Offset: 0x00409A3C
	// (set) Token: 0x0601099A RID: 67994 RVA: 0x0040B844 File Offset: 0x00409A44
	public override string event_id { get; set; } = "2002";

	// Token: 0x04007CFA RID: 31994
	public float i_drift_distance;

	// Token: 0x04007CFB RID: 31995
	public float i_drift_time;
}
