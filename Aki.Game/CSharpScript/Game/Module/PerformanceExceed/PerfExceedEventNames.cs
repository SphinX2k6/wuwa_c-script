using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x02004323 RID: 17187
	[NullableContext(1)]
	[Nullable(0)]
	public static class PerfExceedEventNames
	{
		// Token: 0x0602B6B7 RID: 177847 RVA: 0x00C3495C File Offset: 0x00C32B5C
		public static string GetEventName(PerfExceedSubMetric metric)
		{
			string result;
			switch (metric)
			{
			case PerfExceedSubMetric.Particles:
				result = "perf_exceed_particles";
				break;
			case PerfExceedSubMetric.Emitters:
				result = "perf_exceed_emitters";
				break;
			case PerfExceedSubMetric.Active:
				result = "perf_exceed_active";
				break;
			case PerfExceedSubMetric.Scalability:
				result = "perf_exceed_scalability";
				break;
			default:
				result = "perf_exceed_unknown";
				break;
			}
			return result;
		}

		// Token: 0x04017779 RID: 96121
		public const string PARTICLES = "perf_exceed_particles";

		// Token: 0x0401777A RID: 96122
		public const string EMITTERS = "perf_exceed_emitters";

		// Token: 0x0401777B RID: 96123
		public const string ACTIVE = "perf_exceed_active";

		// Token: 0x0401777C RID: 96124
		public const string SCALABILITY = "perf_exceed_scalability";
	}
}
