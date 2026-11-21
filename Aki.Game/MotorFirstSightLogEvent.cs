using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F6 RID: 5622
[NullableContext(1)]
[Nullable(0)]
public class MotorFirstSightLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F2 RID: 5362
	// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x00417F60 File Offset: 0x00416160
	// (set) Token: 0x0600DE0A RID: 56842 RVA: 0x00417F68 File Offset: 0x00416168
	public override string event_id { get; set; } = "2001";

	// Token: 0x04007E06 RID: 32262
	public float i_view_switching;
}
