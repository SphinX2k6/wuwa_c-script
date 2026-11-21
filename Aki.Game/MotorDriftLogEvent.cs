using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F7 RID: 5623
[NullableContext(1)]
[Nullable(0)]
public class MotorDriftLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F3 RID: 5363
	// (get) Token: 0x0600DE0C RID: 56844 RVA: 0x00417F84 File Offset: 0x00416184
	// (set) Token: 0x0600DE0D RID: 56845 RVA: 0x00417F8C File Offset: 0x0041618C
	public override string event_id { get; set; } = "2002";

	// Token: 0x04007E08 RID: 32264
	public float i_drift_distance;

	// Token: 0x04007E09 RID: 32265
	public float i_drift_time;
}
