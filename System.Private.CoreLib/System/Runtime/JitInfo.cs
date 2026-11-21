using System;
using System.Diagnostics.Tracing;

namespace System.Runtime
{
	// Token: 0x020004FF RID: 1279
	public static class JitInfo
	{
		// Token: 0x06004827 RID: 18471 RVA: 0x000F0667 File Offset: 0x000EE867
		public static long GetCompiledILBytes(bool currentThread = false)
		{
			if (!currentThread)
			{
				return (long)EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.JIT_IL_BYTES_JITTED);
			}
			return 0L;
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x000F0675 File Offset: 0x000EE875
		public static long GetCompiledMethodCount(bool currentThread = false)
		{
			if (!currentThread)
			{
				return (long)EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.JIT_METHODS_JITTED);
			}
			return 0L;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x000F0683 File Offset: 0x000EE883
		private static long GetCompilationTimeInTicks(bool currentThread = false)
		{
			if (!currentThread)
			{
				return (long)EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.JIT_TICKS_IN_JIT);
			}
			return 0L;
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x000F0691 File Offset: 0x000EE891
		public static TimeSpan GetCompilationTime(bool currentThread = false)
		{
			return TimeSpan.FromTicks(JitInfo.GetCompilationTimeInTicks(currentThread));
		}
	}
}
