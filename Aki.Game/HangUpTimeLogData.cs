using System;
using System.Runtime.CompilerServices;

// Token: 0x0200158A RID: 5514
[NullableContext(1)]
[Nullable(0)]
public class HangUpTimeLogData : PlayerCommonLogData
{
	// Token: 0x1700148F RID: 5263
	// (get) Token: 0x0600DCD3 RID: 56531 RVA: 0x00416727 File Offset: 0x00414927
	// (set) Token: 0x0600DCD4 RID: 56532 RVA: 0x0041672F File Offset: 0x0041492F
	public override string event_id { get; set; } = "7";

	// Token: 0x04007B32 RID: 31538
	public string f_hang_up_time = "";
}
