using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000350 RID: 848
	internal static class Utilities
	{
		// Token: 0x06003AE1 RID: 15073 RVA: 0x000C41A1 File Offset: 0x000C23A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int SelectBucketIndex(int bufferSize)
		{
			return BitOperations.Log2((uint)(bufferSize - 1 | 15)) - 3;
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x000C41B0 File Offset: 0x000C23B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetMaxSizeForBucket(int binIndex)
		{
			return 16 << binIndex;
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x000C41BC File Offset: 0x000C23BC
		internal static Utilities.MemoryPressure GetMemoryPressure()
		{
			GCMemoryInfo gcmemoryInfo = GC.GetGCMemoryInfo();
			if ((double)gcmemoryInfo.MemoryLoadBytes >= (double)gcmemoryInfo.HighMemoryLoadThresholdBytes * 0.9)
			{
				return Utilities.MemoryPressure.High;
			}
			if ((double)gcmemoryInfo.MemoryLoadBytes >= (double)gcmemoryInfo.HighMemoryLoadThresholdBytes * 0.7)
			{
				return Utilities.MemoryPressure.Medium;
			}
			return Utilities.MemoryPressure.Low;
		}

		// Token: 0x02000351 RID: 849
		internal enum MemoryPressure
		{
			// Token: 0x04000C5C RID: 3164
			Low,
			// Token: 0x04000C5D RID: 3165
			Medium,
			// Token: 0x04000C5E RID: 3166
			High
		}
	}
}
