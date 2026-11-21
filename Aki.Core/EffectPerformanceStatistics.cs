using System;
using System.Runtime.CompilerServices;

// Token: 0x020000C3 RID: 195
public class EffectPerformanceStatistics
{
	// Token: 0x040004E4 RID: 1252
	public long? Frame;

	// Token: 0x040004E5 RID: 1253
	public double StartTime = -1.0;

	// Token: 0x040004E6 RID: 1254
	public double EndTime = -1.0;

	// Token: 0x040004E7 RID: 1255
	public int ParticleCount;

	// Token: 0x040004E8 RID: 1256
	public int EmitterCount;

	// Token: 0x040004E9 RID: 1257
	[Nullable(1)]
	public string Type = "None";
}
