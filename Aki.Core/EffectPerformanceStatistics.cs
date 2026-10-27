using System;
using System.Runtime.CompilerServices;

// Token: 0x020000C1 RID: 193
public class EffectPerformanceStatistics
{
	// Token: 0x040004D6 RID: 1238
	public long? Frame;

	// Token: 0x040004D7 RID: 1239
	public double StartTime = -1.0;

	// Token: 0x040004D8 RID: 1240
	public double EndTime = -1.0;

	// Token: 0x040004D9 RID: 1241
	public int ParticleCount;

	// Token: 0x040004DA RID: 1242
	public int EmitterCount;

	// Token: 0x040004DB RID: 1243
	[Nullable(1)]
	public string Type = "None";
}
