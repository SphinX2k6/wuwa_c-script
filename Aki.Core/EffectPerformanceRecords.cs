using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000C2 RID: 194
public class EffectPerformanceRecords
{
	// Token: 0x040004DC RID: 1244
	public int TickCount;

	// Token: 0x040004DD RID: 1245
	public float Duration;

	// Token: 0x040004DE RID: 1246
	[Nullable(1)]
	public List<EffectPerformanceStatistics> Records = new List<EffectPerformanceStatistics>();
}
