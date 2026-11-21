using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000121 RID: 289
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class GCMemoryInfoData
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00030C26 File Offset: 0x0002EE26
		internal ReadOnlySpan<GCGenerationInfo> GenerationInfoAsSpan
		{
			get
			{
				return MemoryMarshal.CreateReadOnlySpan<GCGenerationInfo>(ref this._generationInfo0, 5);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00030C34 File Offset: 0x0002EE34
		internal ReadOnlySpan<TimeSpan> PauseDurationsAsSpan
		{
			get
			{
				return MemoryMarshal.CreateReadOnlySpan<TimeSpan>(ref this._pauseDuration0, 2);
			}
		}

		// Token: 0x040003AE RID: 942
		internal long _highMemoryLoadThresholdBytes;

		// Token: 0x040003AF RID: 943
		internal long _totalAvailableMemoryBytes;

		// Token: 0x040003B0 RID: 944
		internal long _memoryLoadBytes;

		// Token: 0x040003B1 RID: 945
		internal long _heapSizeBytes;

		// Token: 0x040003B2 RID: 946
		internal long _fragmentedBytes;

		// Token: 0x040003B3 RID: 947
		internal long _totalCommittedBytes;

		// Token: 0x040003B4 RID: 948
		internal long _promotedBytes;

		// Token: 0x040003B5 RID: 949
		internal long _pinnedObjectsCount;

		// Token: 0x040003B6 RID: 950
		internal long _finalizationPendingCount;

		// Token: 0x040003B7 RID: 951
		internal long _index;

		// Token: 0x040003B8 RID: 952
		internal int _generation;

		// Token: 0x040003B9 RID: 953
		internal int _pauseTimePercentage;

		// Token: 0x040003BA RID: 954
		internal byte _compacted;

		// Token: 0x040003BB RID: 955
		internal byte _concurrent;

		// Token: 0x040003BC RID: 956
		private GCGenerationInfo _generationInfo0;

		// Token: 0x040003BD RID: 957
		private GCGenerationInfo _generationInfo1;

		// Token: 0x040003BE RID: 958
		private GCGenerationInfo _generationInfo2;

		// Token: 0x040003BF RID: 959
		private GCGenerationInfo _generationInfo3;

		// Token: 0x040003C0 RID: 960
		private GCGenerationInfo _generationInfo4;

		// Token: 0x040003C1 RID: 961
		private TimeSpan _pauseDuration0;

		// Token: 0x040003C2 RID: 962
		private TimeSpan _pauseDuration1;
	}
}
