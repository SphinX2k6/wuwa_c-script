using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	public static class GC
	{
		// Token: 0x0600042F RID: 1071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetCollectionCount(int generation);

		// Token: 0x06000430 RID: 1072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxGeneration();

		// Token: 0x06000431 RID: 1073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalCollect(int generation);

		// Token: 0x06000432 RID: 1074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void AddPressure(ulong bytesAllocated);

		// Token: 0x06000433 RID: 1075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RemovePressure(ulong bytesRemoved);

		// Token: 0x06000434 RID: 1076
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void register_ephemeron_array(Ephemeron[] array);

		// Token: 0x06000435 RID: 1077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object get_ephemeron_tombstone();

		// Token: 0x06000436 RID: 1078
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetAllocatedBytesForCurrentThread();

		// Token: 0x06000437 RID: 1079
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalAllocatedBytes(bool precise = false);

		// Token: 0x06000438 RID: 1080 RVA: 0x0000FC5C File Offset: 0x0000DE5C
		public static void AddMemoryPressure(long bytesAllocated)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<long>(bytesAllocated, "bytesAllocated");
			if (8 == 4)
			{
			}
			GC.AddPressure((ulong)bytesAllocated);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000FC77 File Offset: 0x0000DE77
		public static void RemoveMemoryPressure(long bytesAllocated)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<long>(bytesAllocated, "bytesAllocated");
			if (8 == 4)
			{
			}
			GC.RemovePressure((ulong)bytesAllocated);
		}

		// Token: 0x0600043A RID: 1082
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetGeneration(object obj);

		// Token: 0x0600043B RID: 1083 RVA: 0x0000FC92 File Offset: 0x0000DE92
		public static void Collect(int generation)
		{
			GC.Collect(generation, GCCollectionMode.Default);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000FC9B File Offset: 0x0000DE9B
		public static void Collect()
		{
			GC.InternalCollect(GC.MaxGeneration);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000FCA7 File Offset: 0x0000DEA7
		public static void Collect(int generation, GCCollectionMode mode)
		{
			GC.Collect(generation, mode, true);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000FCB1 File Offset: 0x0000DEB1
		public static void Collect(int generation, GCCollectionMode mode, bool blocking)
		{
			GC.Collect(generation, mode, blocking, false);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000FCBC File Offset: 0x0000DEBC
		public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(generation, "generation");
			if (mode < GCCollectionMode.Default || mode > GCCollectionMode.Aggressive)
			{
				throw new ArgumentOutOfRangeException("mode", SR.ArgumentOutOfRange_Enum);
			}
			GC.InternalCollect(generation);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000FCE7 File Offset: 0x0000DEE7
		public static int CollectionCount(int generation)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(generation, "generation");
			return GC.GetCollectionCount(generation);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KeepAlive(object obj)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		public static int GetGeneration(WeakReference wo)
		{
			object target = wo.Target;
			ArgumentNullException.ThrowIfNull(target, "wo");
			return GC.GetGeneration(target);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public static int MaxGeneration
		{
			get
			{
				return GC.GetMaxGeneration();
			}
		}

		// Token: 0x06000444 RID: 1092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WaitForPendingFinalizers();

		// Token: 0x06000445 RID: 1093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _SuppressFinalize(object o);

		// Token: 0x06000446 RID: 1094 RVA: 0x0000FD1B File Offset: 0x0000DF1B
		public static void SuppressFinalize(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			GC._SuppressFinalize(obj);
		}

		// Token: 0x06000447 RID: 1095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _ReRegisterForFinalize(object o);

		// Token: 0x06000448 RID: 1096 RVA: 0x0000FD2E File Offset: 0x0000DF2E
		public static void ReRegisterForFinalize(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			GC._ReRegisterForFinalize(obj);
		}

		// Token: 0x06000449 RID: 1097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalMemory(bool forceFullCollection);

		// Token: 0x0600044A RID: 1098 RVA: 0x0000FD41 File Offset: 0x0000DF41
		private static bool _RegisterForFullGCNotification(int maxGenerationPercentage, int largeObjectHeapPercentage)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000FD41 File Offset: 0x0000DF41
		private static bool _CancelFullGCNotification()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000FD41 File Offset: 0x0000DF41
		private static GCNotificationStatus _WaitForFullGCApproach(int millisecondsTimeout)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000FD41 File Offset: 0x0000DF41
		private static GCNotificationStatus _WaitForFullGCComplete(int millisecondsTimeout)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000FD48 File Offset: 0x0000DF48
		public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold)
		{
			if (maxGenerationThreshold <= 0 || maxGenerationThreshold >= 100)
			{
				throw new ArgumentOutOfRangeException("maxGenerationThreshold", SR.Format(SR.ArgumentOutOfRange_Bounds_Lower_Upper, 1, 99));
			}
			if (largeObjectHeapThreshold <= 0 || largeObjectHeapThreshold >= 100)
			{
				throw new ArgumentOutOfRangeException("largeObjectHeapThreshold", SR.Format(SR.ArgumentOutOfRange_Bounds_Lower_Upper, 1, 99));
			}
			if (!GC._RegisterForFullGCNotification(maxGenerationThreshold, largeObjectHeapThreshold))
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotWithConcurrentGC);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000FDBF File Offset: 0x0000DFBF
		public static void CancelFullGCNotification()
		{
			if (!GC._CancelFullGCNotification())
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotWithConcurrentGC);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000FDD3 File Offset: 0x0000DFD3
		public static GCNotificationStatus WaitForFullGCApproach()
		{
			return GC._WaitForFullGCApproach(-1);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000FDDB File Offset: 0x0000DFDB
		public static GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			return GC._WaitForFullGCApproach(millisecondsTimeout);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000FDEF File Offset: 0x0000DFEF
		public static GCNotificationStatus WaitForFullGCComplete()
		{
			return GC._WaitForFullGCComplete(-1);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000FDF7 File Offset: 0x0000DFF7
		public static GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			return GC._WaitForFullGCComplete(millisecondsTimeout);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000FD41 File Offset: 0x0000DF41
		private static bool StartNoGCRegion(long totalSize, bool hasLohSize, long lohSize, bool disallowFullBlockingGC)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000FE0B File Offset: 0x0000E00B
		public static bool TryStartNoGCRegion(long totalSize)
		{
			return GC.StartNoGCRegion(totalSize, false, 0L, false);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000FE17 File Offset: 0x0000E017
		public static bool TryStartNoGCRegion(long totalSize, long lohSize)
		{
			return GC.StartNoGCRegion(totalSize, true, lohSize, false);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000FE22 File Offset: 0x0000E022
		public static bool TryStartNoGCRegion(long totalSize, bool disallowFullBlockingGC)
		{
			return GC.StartNoGCRegion(totalSize, false, 0L, disallowFullBlockingGC);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000FE2E File Offset: 0x0000E02E
		public static bool TryStartNoGCRegion(long totalSize, long lohSize, bool disallowFullBlockingGC)
		{
			return GC.StartNoGCRegion(totalSize, true, lohSize, disallowFullBlockingGC);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public static void EndNoGCRegion()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600045A RID: 1114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _GetGCMemoryInfo(out long highMemoryLoadThresholdBytes, out long memoryLoadBytes, out long totalAvailableMemoryBytes, out long totalCommittedBytes, out long heapSizeBytes, out long fragmentedBytes);

		// Token: 0x0600045B RID: 1115 RVA: 0x0000FE3C File Offset: 0x0000E03C
		public static GCMemoryInfo GetGCMemoryInfo()
		{
			GCMemoryInfoData gcmemoryInfoData = new GCMemoryInfoData();
			GC._GetGCMemoryInfo(out gcmemoryInfoData._highMemoryLoadThresholdBytes, out gcmemoryInfoData._memoryLoadBytes, out gcmemoryInfoData._totalAvailableMemoryBytes, out gcmemoryInfoData._totalCommittedBytes, out gcmemoryInfoData._heapSizeBytes, out gcmemoryInfoData._fragmentedBytes);
			return new GCMemoryInfo(gcmemoryInfoData);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static GCMemoryInfo GetGCMemoryInfo(GCKind kind)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600045D RID: 1117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Array AllocPinnedArray(Type t, int length);

		// Token: 0x0600045E RID: 1118 RVA: 0x0000FE7E File Offset: 0x0000E07E
		public static T[] AllocateUninitializedArray<[Nullable(2)] T>(int length, bool pinned = false)
		{
			return GC.AllocateArray<T>(length, pinned);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000FE87 File Offset: 0x0000E087
		public static T[] AllocateArray<[Nullable(2)] T>(int length, bool pinned = false)
		{
			if (pinned)
			{
				return Unsafe.As<T[]>(GC.AllocPinnedArray(typeof(T[]), length));
			}
			return new T[length];
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		internal static ulong GetGenerationSize(int generation)
		{
			switch (generation)
			{
			case 0:
				return EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.GC_NURSERY_SIZE_BYTES);
			case 1:
			case 2:
				return EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.GC_MAJOR_SIZE_BYTES);
			case 3:
				return EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.GC_LARGE_OBJECT_SIZE_BYTES);
			case 4:
				return 0UL;
			default:
				return 0UL;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
		internal static int GetLastGCPercentTimeInGC()
		{
			return (int)EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.GC_LAST_PERCENT_TIME_IN_GC);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000FEE9 File Offset: 0x0000E0E9
		public static TimeSpan GetTotalPauseDuration()
		{
			return TimeSpan.Zero;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		public static IReadOnlyDictionary<string, object> GetConfigurationVariables()
		{
			return new Dictionary<string, object>();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void RefreshMemoryLimit()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void RegisterNoGCRegionCallback(long totalSize, Action callback)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000FEF7 File Offset: 0x0000E0F7
		public static GCNotificationStatus WaitForFullGCApproach(TimeSpan timeout)
		{
			return GC.WaitForFullGCApproach(WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000FF04 File Offset: 0x0000E104
		public static GCNotificationStatus WaitForFullGCComplete(TimeSpan timeout)
		{
			return GC.WaitForFullGCComplete(WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x04000264 RID: 612
		internal static readonly object EPHEMERON_TOMBSTONE = GC.get_ephemeron_tombstone();
	}
}
