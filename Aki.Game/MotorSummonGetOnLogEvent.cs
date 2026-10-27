using System;
using System.Runtime.CompilerServices;

// Token: 0x02002120 RID: 8480
[NullableContext(1)]
[Nullable(0)]
public class MotorSummonGetOnLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C6 RID: 5318
	// (get) Token: 0x0601099C RID: 67996 RVA: 0x0040B860 File Offset: 0x00409A60
	// (set) Token: 0x0601099D RID: 67997 RVA: 0x0040B868 File Offset: 0x00409A68
	public override string event_id { get; set; } = "2003";

	// Token: 0x04007CFD RID: 31997
	public float pos_x;

	// Token: 0x04007CFE RID: 31998
	public float pos_y;

	// Token: 0x04007CFF RID: 31999
	public float pos_z;

	// Token: 0x04007D00 RID: 32000
	public int operation_type;
}
