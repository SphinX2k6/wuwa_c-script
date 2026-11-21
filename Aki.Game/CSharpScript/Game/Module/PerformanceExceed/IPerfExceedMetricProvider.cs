using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200431E RID: 17182
	[NullableContext(1)]
	public interface IPerfExceedMetricProvider
	{
		// Token: 0x170056EB RID: 22251
		// (get) Token: 0x0602B6AA RID: 177834
		string Name { get; }

		// Token: 0x170056EC RID: 22252
		// (get) Token: 0x0602B6AB RID: 177835
		int SampleIntervalMs { get; }

		// Token: 0x0602B6AC RID: 177836
		[NullableContext(2)]
		PerfExceedSample Sample();

		// Token: 0x0602B6AD RID: 177837
		[NullableContext(2)]
		PerfExceedPayload BuildPayload(PerfExceedSubMetric subMetric);
	}
}
