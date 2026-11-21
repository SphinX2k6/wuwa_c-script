using System;
using CSharpScript.Launcher.Platform;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x02004322 RID: 17186
	public static class PerfExceedThresholds
	{
		// Token: 0x0602B6B6 RID: 177846 RVA: 0x00C348F0 File Offset: 0x00C32AF0
		public static int GetThreshold(PerfExceedSubMetric metric)
		{
			int result;
			switch (metric)
			{
			case PerfExceedSubMetric.Particles:
				result = 4000;
				break;
			case PerfExceedSubMetric.Emitters:
				result = ((Platform.Instance.IsHomeConsolePlatform() || Platform.Instance.IsPcPlatform()) ? 600 : 400);
				break;
			case PerfExceedSubMetric.Active:
				result = 1000;
				break;
			case PerfExceedSubMetric.Scalability:
				result = 1000;
				break;
			default:
				result = int.MaxValue;
				break;
			}
			return result;
		}

		// Token: 0x04017774 RID: 96116
		public const int ACTIVE = 1000;

		// Token: 0x04017775 RID: 96117
		public const int SCALABILITY = 1000;

		// Token: 0x04017776 RID: 96118
		public const int PARTICLES = 4000;

		// Token: 0x04017777 RID: 96119
		public const int PC_CONSOLE_EMITTERS = 600;

		// Token: 0x04017778 RID: 96120
		public const int MOBILE_EMITTERS = 400;
	}
}
