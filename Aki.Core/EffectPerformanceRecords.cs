using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000C4 RID: 196
public class EffectPerformanceRecords
{
	// Token: 0x040004EA RID: 1258
	public int TickCount;

	// Token: 0x040004EB RID: 1259
	public float Duration;

	// Token: 0x040004EC RID: 1260
	[Nullable(1)]
	public List<EffectPerformanceStatistics> Records = new List<EffectPerformanceStatistics>();
}
