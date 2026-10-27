using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F0 RID: 8432
[NullableContext(1)]
[Nullable(0)]
public class OnClickFunctionItemLogEvent : PlayerCommonLogData
{
	// Token: 0x17001496 RID: 5270
	// (get) Token: 0x0601090C RID: 67852 RVA: 0x0040AFA3 File Offset: 0x004091A3
	// (set) Token: 0x0601090D RID: 67853 RVA: 0x0040AFAB File Offset: 0x004091AB
	public override string event_id { get; set; } = "1854";

	// Token: 0x04007C30 RID: 31792
	public int i_id;

	// Token: 0x04007C31 RID: 31793
	public int i_type;
}
