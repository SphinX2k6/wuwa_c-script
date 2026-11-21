using System;

namespace System.Runtime
{
	// Token: 0x020004FD RID: 1277
	public static class GCSettings
	{
		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool IsServerGC
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x000F0617 File Offset: 0x000EE817
		private static GCSettings.SetLatencyModeStatus SetGCLatencyMode(GCLatencyMode newLatencyMode)
		{
			if (newLatencyMode != GCLatencyMode.Batch)
			{
				throw new PlatformNotSupportedException();
			}
			return GCSettings.SetLatencyModeStatus.Succeeded;
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x000F0623 File Offset: 0x000EE823
		private static void SetLOHCompactionMode(GCLargeObjectHeapCompactionMode newLOHCompactionMode)
		{
			if (newLOHCompactionMode != GCLargeObjectHeapCompactionMode.Default)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x00007B65 File Offset: 0x00005D65
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x000F062F File Offset: 0x000EE82F
		public static GCLatencyMode LatencyMode
		{
			get
			{
				return GCLatencyMode.Batch;
			}
			set
			{
				if (value < GCLatencyMode.Batch || value > GCLatencyMode.SustainedLowLatency)
				{
					ThrowHelper.ArgumentOutOfRangeException_Enum_Value();
				}
				if (GCSettings.SetGCLatencyMode(value) == GCSettings.SetLatencyModeStatus.NoGCInProgress)
				{
					throw new InvalidOperationException(SR.InvalidOperation_SetLatencyModeNoGC);
				}
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x000070DD File Offset: 0x000052DD
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x000F0652 File Offset: 0x000EE852
		public static GCLargeObjectHeapCompactionMode LargeObjectHeapCompactionMode
		{
			get
			{
				return GCLargeObjectHeapCompactionMode.Default;
			}
			set
			{
				if (value < GCLargeObjectHeapCompactionMode.Default || value > GCLargeObjectHeapCompactionMode.CompactOnce)
				{
					ThrowHelper.ArgumentOutOfRangeException_Enum_Value();
				}
				GCSettings.SetLOHCompactionMode(value);
			}
		}

		// Token: 0x020004FE RID: 1278
		private enum SetLatencyModeStatus
		{
			// Token: 0x04001120 RID: 4384
			Succeeded,
			// Token: 0x04001121 RID: 4385
			NoGCInProgress
		}
	}
}
