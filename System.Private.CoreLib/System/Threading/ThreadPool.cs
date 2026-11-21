using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x02000437 RID: 1079
	[NullableContext(1)]
	[Nullable(0)]
	public static class ThreadPool
	{
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x000DCDC0 File Offset: 0x000DAFC0
		internal static bool EnableWorkerTracking
		{
			get
			{
				return ThreadPool.IsWorkerTrackingEnabledInConfig && EventSource.IsSupported;
			}
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000DCDD0 File Offset: 0x000DAFD0
		[UnsupportedOSPlatform("browser")]
		[CLSCompliant(false)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			if (millisecondsTimeOutInterval > 2147483647U && millisecondsTimeOutInterval != 4294967295U)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", SR.ArgumentOutOfRange_LessEqualToIntegerMaxVal);
			}
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, true);
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x000DCDFA File Offset: 0x000DAFFA
		[UnsupportedOSPlatform("browser")]
		[CLSCompliant(false)]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			if (millisecondsTimeOutInterval > 2147483647U && millisecondsTimeOutInterval != 4294967295U)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", SR.ArgumentOutOfRange_NeedNonNegOrNegative1);
			}
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, false);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x000DCE24 File Offset: 0x000DB024
		[UnsupportedOSPlatform("browser")]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeOutInterval, -1, "millisecondsTimeOutInterval");
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, true);
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x000DCE3E File Offset: 0x000DB03E
		[UnsupportedOSPlatform("browser")]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeOutInterval, -1, "millisecondsTimeOutInterval");
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, false);
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x000DCE58 File Offset: 0x000DB058
		[UnsupportedOSPlatform("browser")]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(millisecondsTimeOutInterval, -1L, "millisecondsTimeOutInterval");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(millisecondsTimeOutInterval, 2147483647L, "millisecondsTimeOutInterval");
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, true);
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x000DCE85 File Offset: 0x000DB085
		[UnsupportedOSPlatform("browser")]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(millisecondsTimeOutInterval, -1L, "millisecondsTimeOutInterval");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(millisecondsTimeOutInterval, 2147483647L, "millisecondsTimeOutInterval");
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)millisecondsTimeOutInterval, executeOnlyOnce, false);
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x000DCEB4 File Offset: 0x000DB0B4
		[UnsupportedOSPlatform("browser")]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			long num = (long)timeout.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "timeout");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, 2147483647L, "timeout");
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, true);
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x000DCEF8 File Offset: 0x000DB0F8
		[UnsupportedOSPlatform("browser")]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, [Nullable(2)] object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			long num = (long)timeout.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "timeout");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, 2147483647L, "timeout");
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, false);
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x000DCF39 File Offset: 0x000DB139
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			return ThreadPool.QueueUserWorkItem(callBack, null);
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x000DCF44 File Offset: 0x000DB144
		public static bool QueueUserWorkItem(WaitCallback callBack, [Nullable(2)] object state)
		{
			if (callBack == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.callBack);
			}
			ExecutionContext executionContext = ExecutionContext.Capture();
			object callback = (executionContext == null || executionContext.IsDefault) ? new QueueUserWorkItemCallbackDefaultContext(callBack, state) : new QueueUserWorkItemCallback(callBack, state, executionContext);
			ThreadPool.s_workQueue.Enqueue(callback, true);
			return true;
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x000DCF8C File Offset: 0x000DB18C
		public static bool QueueUserWorkItem<[Nullable(2)] TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			if (callBack == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.callBack);
			}
			ExecutionContext executionContext = ExecutionContext.Capture();
			object callback = (executionContext == null || executionContext.IsDefault) ? new QueueUserWorkItemCallbackDefaultContext<TState>(callBack, state) : new QueueUserWorkItemCallback<TState>(callBack, state, executionContext);
			ThreadPool.s_workQueue.Enqueue(callback, !preferLocal);
			return true;
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x000DCFD8 File Offset: 0x000DB1D8
		public static bool UnsafeQueueUserWorkItem<[Nullable(2)] TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			if (callBack == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.callBack);
			}
			if (callBack == ThreadPool.s_invokeAsyncStateMachineBox)
			{
				if (!(state is IAsyncStateMachineBox))
				{
					ThrowHelper.ThrowUnexpectedStateForKnownCallback(state);
				}
				ThreadPool.UnsafeQueueUserWorkItemInternal(state, preferLocal);
				return true;
			}
			ThreadPool.s_workQueue.Enqueue(new QueueUserWorkItemCallbackDefaultContext<TState>(callBack, state), !preferLocal);
			return true;
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x000DD034 File Offset: 0x000DB234
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, [Nullable(2)] object state)
		{
			if (callBack == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.callBack);
			}
			object callback = new QueueUserWorkItemCallbackDefaultContext(callBack, state);
			ThreadPool.s_workQueue.Enqueue(callback, true);
			return true;
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x000DD060 File Offset: 0x000DB260
		public static bool UnsafeQueueUserWorkItem(IThreadPoolWorkItem callBack, bool preferLocal)
		{
			if (callBack == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.callBack);
			}
			if (callBack is Task)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.callBack);
			}
			ThreadPool.UnsafeQueueUserWorkItemInternal(callBack, preferLocal);
			return true;
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x000DD083 File Offset: 0x000DB283
		internal static void UnsafeQueueUserWorkItemInternal(object callBack, bool preferLocal)
		{
			ThreadPool.s_workQueue.Enqueue(callBack, !preferLocal);
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x000DD094 File Offset: 0x000DB294
		internal static void UnsafeQueueHighPriorityWorkItemInternal(IThreadPoolWorkItem callBack)
		{
			ThreadPool.s_workQueue.EnqueueAtHighPriority(callBack);
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x000DD0A1 File Offset: 0x000DB2A1
		internal static bool TryPopCustomWorkItem(object workItem)
		{
			return ThreadPoolWorkQueue.LocalFindAndPop(workItem);
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x000DD0A9 File Offset: 0x000DB2A9
		internal static IEnumerable<object> GetQueuedWorkItems()
		{
			foreach (object obj in ThreadPool.s_workQueue.highPriorityWorkItems)
			{
				yield return obj;
			}
			IEnumerator<object> enumerator = null;
			foreach (ConcurrentQueue<object> concurrentQueue in ThreadPool.s_workQueue._assignableWorkItemQueues)
			{
				foreach (object obj2 in concurrentQueue)
				{
					yield return obj2;
				}
				enumerator = null;
			}
			ConcurrentQueue<object>[] array = null;
			foreach (object obj3 in ThreadPool.s_workQueue.workItems)
			{
				yield return obj3;
			}
			enumerator = null;
			foreach (ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue in ThreadPoolWorkQueue.WorkStealingQueueList.Queues)
			{
				if (workStealingQueue != null && workStealingQueue.m_array != null)
				{
					object[] items = workStealingQueue.m_array;
					int num;
					for (int i = 0; i < items.Length; i = num + 1)
					{
						object obj4 = items[i];
						if (obj4 != null)
						{
							yield return obj4;
						}
						num = i;
					}
					items = null;
				}
			}
			ThreadPoolWorkQueue.WorkStealingQueue[] array2 = null;
			yield break;
			yield break;
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x000DD0B4 File Offset: 0x000DB2B4
		public static long PendingWorkItemCount
		{
			get
			{
				ThreadPoolWorkQueue threadPoolWorkQueue = ThreadPool.s_workQueue;
				return ThreadPoolWorkQueue.LocalCount + threadPoolWorkQueue.GlobalCount;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x000DD0D3 File Offset: 0x000DB2D3
		internal static bool UseWindowsThreadPool { get; } = AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.UseWindowsThreadPool", "DOTNET_ThreadPool_UseWindowsThreadPool", false);

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x000DD0DA File Offset: 0x000DB2DA
		internal static bool YieldFromDispatchLoop
		{
			get
			{
				return ThreadPool.UseWindowsThreadPool;
			}
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x000DD0E1 File Offset: 0x000DB2E1
		[NullableContext(0)]
		[CLSCompliant(false)]
		[SupportedOSPlatform("windows")]
		public unsafe static bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return ThreadPool.UnsafeQueueNativeOverlappedPortableCore(overlapped);
			}
			return WindowsThreadPool.UnsafeQueueNativeOverlapped(overlapped);
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x000DD0F7 File Offset: 0x000DB2F7
		[Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated. Use ThreadPool.BindHandle(SafeHandle) instead.")]
		[SupportedOSPlatform("windows")]
		public static bool BindHandle(IntPtr osHandle)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return ThreadPool.BindHandlePortableCore(osHandle);
			}
			return WindowsThreadPool.BindHandle(osHandle);
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x000DD10D File Offset: 0x000DB30D
		[SupportedOSPlatform("windows")]
		public static bool BindHandle(SafeHandle osHandle)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return ThreadPool.BindHandlePortableCore(osHandle);
			}
			return WindowsThreadPool.BindHandle(osHandle);
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x000DD123 File Offset: 0x000DB323
		internal static void InitializeForThreadPoolThread()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.InitializeForThreadPoolThread();
			}
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x000DD131 File Offset: 0x000DB331
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void IncrementCompletedWorkItemCount()
		{
			WindowsThreadPool.IncrementCompletedWorkItemCount();
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x000DD138 File Offset: 0x000DB338
		internal static object GetOrCreateThreadLocalCompletionCountObject()
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return PortableThreadPool.ThreadPoolInstance.GetOrCreateThreadLocalCompletionCountObject();
			}
			return WindowsThreadPool.GetOrCreateThreadLocalCompletionCountObject();
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x000DD151 File Offset: 0x000DB351
		public static bool SetMaxThreads(int workerThreads, int completionPortThreads)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return PortableThreadPool.ThreadPoolInstance.SetMaxThreads(workerThreads, completionPortThreads);
			}
			return WindowsThreadPool.SetMaxThreads(workerThreads, completionPortThreads);
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x000DD16E File Offset: 0x000DB36E
		public static void GetMaxThreads(out int workerThreads, out int completionPortThreads)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
				return;
			}
			PortableThreadPool.ThreadPoolInstance.GetMaxThreads(out workerThreads, out completionPortThreads);
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x000DD18B File Offset: 0x000DB38B
		public static bool SetMinThreads(int workerThreads, int completionPortThreads)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return PortableThreadPool.ThreadPoolInstance.SetMinThreads(workerThreads, completionPortThreads);
			}
			return WindowsThreadPool.SetMinThreads(workerThreads, completionPortThreads);
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x000DD1A8 File Offset: 0x000DB3A8
		public static void GetMinThreads(out int workerThreads, out int completionPortThreads)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
				return;
			}
			PortableThreadPool.ThreadPoolInstance.GetMinThreads(out workerThreads, out completionPortThreads);
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x000DD1C5 File Offset: 0x000DB3C5
		public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
				return;
			}
			PortableThreadPool.ThreadPoolInstance.GetAvailableThreads(out workerThreads, out completionPortThreads);
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x000DD1E2 File Offset: 0x000DB3E2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NotifyWorkItemProgress()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.NotifyWorkItemProgress();
				return;
			}
			PortableThreadPool.ThreadPoolInstance.NotifyWorkItemProgress();
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x000DD1FB File Offset: 0x000DB3FB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool NotifyWorkItemComplete(object threadLocalCompletionCountObject, int currentTimeMs)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return PortableThreadPool.ThreadPoolInstance.NotifyWorkItemComplete(threadLocalCompletionCountObject, currentTimeMs);
			}
			return WindowsThreadPool.NotifyWorkItemComplete(threadLocalCompletionCountObject, currentTimeMs);
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x000DD218 File Offset: 0x000DB418
		internal static bool NotifyThreadBlocked()
		{
			return !ThreadPool.UseWindowsThreadPool && PortableThreadPool.ThreadPoolInstance.NotifyThreadBlocked();
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x000DD22D File Offset: 0x000DB42D
		internal static void NotifyThreadUnblocked()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.NotifyThreadUnblocked();
				return;
			}
			PortableThreadPool.ThreadPoolInstance.NotifyThreadUnblocked();
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x000DD246 File Offset: 0x000DB446
		internal static void RequestWorkerThread()
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				WindowsThreadPool.RequestWorkerThread();
				return;
			}
			PortableThreadPool.ThreadPoolInstance.RequestWorker();
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x000DD25F File Offset: 0x000DB45F
		internal static void ReportThreadStatus(bool isWorking)
		{
			PortableThreadPool.ThreadPoolInstance.ReportThreadStatus(isWorking);
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x000DD26C File Offset: 0x000DB46C
		public static int ThreadCount
		{
			get
			{
				if (!ThreadPool.UseWindowsThreadPool)
				{
					return PortableThreadPool.ThreadPoolInstance.ThreadCount;
				}
				return WindowsThreadPool.ThreadCount;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x000DD285 File Offset: 0x000DB485
		public static long CompletedWorkItemCount
		{
			get
			{
				if (!ThreadPool.UseWindowsThreadPool)
				{
					return PortableThreadPool.ThreadPoolInstance.CompletedWorkItemCount;
				}
				return WindowsThreadPool.CompletedWorkItemCount;
			}
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x000DD29E File Offset: 0x000DB49E
		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, bool flowExecutionContext)
		{
			if (ThreadPool.UseWindowsThreadPool)
			{
				return WindowsThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, flowExecutionContext);
			}
			return PortableThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, flowExecutionContext);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x000DD2C2 File Offset: 0x000DB4C2
		[SupportedOSPlatform("windows")]
		private unsafe static bool UnsafeQueueNativeOverlappedPortableCore(NativeOverlapped* overlapped)
		{
			if (overlapped == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.overlapped);
			}
			overlapped->InternalLow = IntPtr.Zero;
			PortableThreadPool.ThreadPoolInstance.QueueNativeOverlapped(overlapped);
			return true;
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x000DD2E7 File Offset: 0x000DB4E7
		[Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated. Use ThreadPool.BindHandle(SafeHandle) instead.")]
		[SupportedOSPlatform("windows")]
		private static bool BindHandlePortableCore(IntPtr osHandle)
		{
			PortableThreadPool.ThreadPoolInstance.RegisterForIOCompletionNotifications(osHandle);
			return true;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000DD2F8 File Offset: 0x000DB4F8
		[SupportedOSPlatform("windows")]
		private static bool BindHandlePortableCore(SafeHandle osHandle)
		{
			ArgumentNullException.ThrowIfNull(osHandle, "osHandle");
			bool flag = false;
			bool result;
			try
			{
				osHandle.DangerousAddRef(ref flag);
				PortableThreadPool.ThreadPoolInstance.RegisterForIOCompletionNotifications(osHandle.DangerousGetHandle());
				result = true;
			}
			finally
			{
				if (flag)
				{
					osHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x04000E4D RID: 3661
		internal static readonly ThreadPoolWorkQueue s_workQueue = new ThreadPoolWorkQueue();

		// Token: 0x04000E4E RID: 3662
		internal static readonly Action<object> s_invokeAsyncStateMachineBox = delegate(object state)
		{
			IAsyncStateMachineBox asyncStateMachineBox = state as IAsyncStateMachineBox;
			if (asyncStateMachineBox != null)
			{
				asyncStateMachineBox.MoveNext();
				return;
			}
			ThrowHelper.ThrowUnexpectedStateForKnownCallback(state);
		};

		// Token: 0x04000E50 RID: 3664
		private static readonly bool s_useWindowsThreadPool = ThreadPool.UseWindowsThreadPool;

		// Token: 0x04000E51 RID: 3665
		private static readonly bool IsWorkerTrackingEnabledInConfig = !ThreadPool.UseWindowsThreadPool && AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.EnableWorkerTracking", "DOTNET_ThreadPool_EnableWorkerTracking", false);
	}
}
