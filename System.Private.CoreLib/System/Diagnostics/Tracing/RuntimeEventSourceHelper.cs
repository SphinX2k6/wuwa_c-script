using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200095C RID: 2396
	internal static class RuntimeEventSourceHelper
	{
		// Token: 0x06008EB8 RID: 36536 RVA: 0x001608FC File Offset: 0x0015EAFC
		internal static double GetCpuUsage()
		{
			double result = 0.0;
			long num;
			long num2;
			long num3;
			long num4;
			long num5;
			long num6;
			if (Interop.Kernel32.GetProcessTimes(Interop.Kernel32.GetCurrentProcess(), out num, out num2, out num3, out num4) && Interop.Kernel32.GetSystemTimes(out num2, out num5, out num6))
			{
				long num7 = num4 - RuntimeEventSourceHelper.s_prevProcUserTime + (num3 - RuntimeEventSourceHelper.s_prevProcKernelTime);
				long num8 = num6 - RuntimeEventSourceHelper.s_prevSystemUserTime + (num5 - RuntimeEventSourceHelper.s_prevSystemKernelTime);
				if (RuntimeEventSourceHelper.s_prevSystemUserTime != 0L && RuntimeEventSourceHelper.s_prevSystemKernelTime != 0L && num8 != 0L)
				{
					result = (double)num7 * 100.0 / (double)num8;
				}
				RuntimeEventSourceHelper.s_prevProcUserTime = num4;
				RuntimeEventSourceHelper.s_prevProcKernelTime = num3;
				RuntimeEventSourceHelper.s_prevSystemUserTime = num6;
				RuntimeEventSourceHelper.s_prevSystemKernelTime = num5;
			}
			return result;
		}

		// Token: 0x040021CA RID: 8650
		private static long s_prevProcUserTime;

		// Token: 0x040021CB RID: 8651
		private static long s_prevProcKernelTime;

		// Token: 0x040021CC RID: 8652
		private static long s_prevSystemUserTime;

		// Token: 0x040021CD RID: 8653
		private static long s_prevSystemKernelTime;
	}
}
