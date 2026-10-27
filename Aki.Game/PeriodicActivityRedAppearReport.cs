using System;
using System.Runtime.CompilerServices;

// Token: 0x02002155 RID: 8533
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRedAppearReport : PlayerCommonLogData
{
	// Token: 0x170014F8 RID: 5368
	// (get) Token: 0x06010A35 RID: 68149 RVA: 0x0040C0B3 File Offset: 0x0040A2B3
	// (set) Token: 0x06010A36 RID: 68150 RVA: 0x0040C0BB File Offset: 0x0040A2BB
	public override string event_id { get; set; } = "1838";

	// Token: 0x04007DFB RID: 32251
	public int i_activity_id;

	// Token: 0x04007DFC RID: 32252
	public int i_round;
}
