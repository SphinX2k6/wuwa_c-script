using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x02000414 RID: 1044
	internal static class ProcessorIdCache
	{
		// Token: 0x0600418E RID: 16782 RVA: 0x000DAC04 File Offset: 0x000D8E04
		private static int RefreshCurrentProcessorId()
		{
			int num = Thread.GetCurrentProcessorNumber();
			if (num < 0)
			{
				num = Environment.CurrentManagedThreadId;
			}
			ProcessorIdCache.t_currentProcessorIdCache = ((num << 16 & int.MaxValue) | ProcessorIdCache.s_processorIdRefreshRate);
			return num;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x000DAC38 File Offset: 0x000D8E38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetCurrentProcessorId()
		{
			if (ProcessorIdCache.s_isProcessorNumberReallyFast)
			{
				return Thread.GetCurrentProcessorNumber();
			}
			int num = ProcessorIdCache.t_currentProcessorIdCache--;
			if ((num & 65535) == 0)
			{
				return ProcessorIdCache.RefreshCurrentProcessorId();
			}
			return num >> 16;
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x000DAC74 File Offset: 0x000D8E74
		internal static bool ProcessorNumberSpeedCheck()
		{
			double num = double.MaxValue;
			double num2 = double.MaxValue;
			ProcessorIdCache.UninlinedThreadStatic();
			if (Thread.GetCurrentProcessorNumber() < 0)
			{
				ProcessorIdCache.s_processorIdRefreshRate = 65535;
				return false;
			}
			long num3 = Stopwatch.Frequency / 1000000L + 1L;
			for (int i = 0; i < 10; i++)
			{
				int num4 = 8;
				long num5;
				do
				{
					num4 *= 2;
					num5 = Stopwatch.GetTimestamp();
					for (int j = 0; j < num4; j++)
					{
						Thread.GetCurrentProcessorNumber();
					}
					num5 = Stopwatch.GetTimestamp() - num5;
				}
				while (num5 < num3);
				num = Math.Min(num, (double)num5 / (double)num4);
				num4 /= 4;
				do
				{
					num4 *= 2;
					num5 = Stopwatch.GetTimestamp();
					for (int k = 0; k < num4; k++)
					{
						ProcessorIdCache.UninlinedThreadStatic();
					}
					num5 = Stopwatch.GetTimestamp() - num5;
				}
				while (num5 < num3);
				num2 = Math.Min(num2, (double)num5 / (double)num4);
			}
			ProcessorIdCache.s_processorIdRefreshRate = Math.Min((int)(num * 5.0 / num2), 5000);
			return ProcessorIdCache.s_processorIdRefreshRate <= 5;
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x000DAD85 File Offset: 0x000D8F85
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int UninlinedThreadStatic()
		{
			return ProcessorIdCache.t_currentProcessorIdCache;
		}

		// Token: 0x04000DE6 RID: 3558
		[ThreadStatic]
		private static int t_currentProcessorIdCache;

		// Token: 0x04000DE7 RID: 3559
		private static int s_processorIdRefreshRate;

		// Token: 0x04000DE8 RID: 3560
		private static readonly bool s_isProcessorNumberReallyFast = ProcessorIdCache.ProcessorNumberSpeedCheck();
	}
}
