using System;
using System.Runtime.CompilerServices;

// Token: 0x020020B3 RID: 8371
[NullableContext(1)]
[Nullable(0)]
public class HangUpTimeLogData : PlayerCommonLogData
{
	// Token: 0x17001462 RID: 5218
	// (get) Token: 0x06010863 RID: 67683 RVA: 0x0040A01F File Offset: 0x0040821F
	// (set) Token: 0x06010864 RID: 67684 RVA: 0x0040A027 File Offset: 0x00408227
	public override string event_id { get; set; } = "7";

	// Token: 0x04007A34 RID: 31284
	public string f_hang_up_time = "";
}
