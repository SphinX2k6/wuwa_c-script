using System;
using System.Runtime.CompilerServices;

// Token: 0x0200162D RID: 5677
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRedAppearReport : PlayerCommonLogData
{
	// Token: 0x17001526 RID: 5414
	// (get) Token: 0x0600DEA8 RID: 57000 RVA: 0x004187FB File Offset: 0x004169FB
	// (set) Token: 0x0600DEA9 RID: 57001 RVA: 0x00418803 File Offset: 0x00416A03
	public override string event_id { get; set; } = "1838";

	// Token: 0x04007F0B RID: 32523
	public int i_activity_id;

	// Token: 0x04007F0C RID: 32524
	public int i_round;
}
