using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Internal;

namespace System.Threading
{
	// Token: 0x0200046D RID: 1133
	internal static class WindowsThreadPool
	{
		// Token: 0x0600439A RID: 17306 RVA: 0x000E165E File Offset: 0x000DF85E
		internal static void InitializeForThreadPoolThread()
		{
			WindowsThreadPool.t_threadCountHolder = new WindowsThreadPool.ThreadCountHolder();
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x000E166A File Offset: 0x000DF86A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void IncrementCompletedWorkItemCount()
		{
			ThreadInt64PersistentCounter.Increment(WindowsThreadPool.GetOrCreateThreadLocalCompletionCountObject());
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000E1676 File Offset: 0x000DF876
		internal static object GetOrCreateThreadLocalCompletionCountObject()
		{
			return WindowsThreadPool.t_completionCountObject ?? WindowsThreadPool.CreateThreadLocalCompletionCountObject();
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000E1686 File Offset: 0x000DF886
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object CreateThreadLocalCompletionCountObject()
		{
			return WindowsThreadPool.t_completionCountObject = WindowsThreadPool.s_completedWorkItemCounter.CreateThreadLocalCountObject();
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool SetMaxThreads(int workerThreads, int completionPortThreads)
		{
			return false;
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x000E1698 File Offset: 0x000DF898
		public static void GetMaxThreads(out int workerThreads, out int completionPortThreads)
		{
			workerThreads = WindowsThreadPool.MaxThreadCount;
			completionPortThreads = WindowsThreadPool.MaxThreadCount;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool SetMinThreads(int workerThreads, int completionPortThreads)
		{
			return false;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000E16A8 File Offset: 0x000DF8A8
		public static void GetMinThreads(out int workerThreads, out int completionPortThreads)
		{
			workerThreads = 0;
			completionPortThreads = 0;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x000E16B0 File Offset: 0x000DF8B0
		public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
		{
			int num = Math.Max(WindowsThreadPool.MaxThreadCount - WindowsThreadPool.s_workingThreadCounter.Count, 0);
			workerThreads = num;
			completionPortThreads = num;
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x000E16DC File Offset: 0x000DF8DC
		public static int ThreadCount
		{
			get
			{
				return WindowsThreadPool.s_threadCount;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x000E16E3 File Offset: 0x000DF8E3
		public static long CompletedWorkItemCount
		{
			get
			{
				return WindowsThreadPool.s_completedWorkItemCounter.Count;
			}
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x000DD131 File Offset: 0x000DB331
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NotifyWorkItemProgress()
		{
			WindowsThreadPool.IncrementCompletedWorkItemCount();
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x000E16EF File Offset: 0x000DF8EF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool NotifyWorkItemComplete(object threadLocalCompletionCountObject, int _)
		{
			ThreadInt64PersistentCounter.Increment(threadLocalCompletionCountObject);
			return true;
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		internal static void NotifyThreadUnblocked()
		{
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x000E16F8 File Offset: 0x000DF8F8
		[UnmanagedCallersOnly]
		private static void DispatchCallback(IntPtr instance, IntPtr context, IntPtr work)
		{
			ThreadPoolCallbackWrapper threadPoolCallbackWrapper = ThreadPoolCallbackWrapper.Enter();
			Interlocked.Increment(ref WindowsThreadPool.s_workingThreadCounter.Count);
			ThreadPoolWorkQueue.Dispatch();
			Interlocked.Decrement(ref WindowsThreadPool.s_workingThreadCounter.Count);
			threadPoolCallbackWrapper.Exit(false);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000E173C File Offset: 0x000DF93C
		internal static void RequestWorkerThread()
		{
			if (WindowsThreadPool.s_work == IntPtr.Zero)
			{
				IntPtr intPtr = Interop.Kernel32.CreateThreadpoolWork(ldftn(DispatchCallback), (char)IntPtr.Zero, IntPtr.Zero);
				if (intPtr == IntPtr.Zero)
				{
					throw new OutOfMemoryException();
				}
				if (Interlocked.CompareExchange(ref WindowsThreadPool.s_work, intPtr, IntPtr.Zero) != IntPtr.Zero)
				{
					Interop.Kernel32.CloseThreadpoolWork(intPtr);
				}
			}
			Interop.Kernel32.SubmitThreadpoolWork(WindowsThreadPool.s_work);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x000E17A0 File Offset: 0x000DF9A0
		internal static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, bool flowExecutionContext)
		{
			ArgumentNullException.ThrowIfNull(waitObject, "waitObject");
			ArgumentNullException.ThrowIfNull(callBack, "callBack");
			_ThreadPoolWaitOrTimerCallback callbackHelper = new _ThreadPoolWaitOrTimerCallback(callBack, state, flowExecutionContext);
			RegisteredWaitHandle registeredWaitHandle = new RegisteredWaitHandle(waitObject.SafeWaitHandle, callbackHelper, millisecondsTimeOutInterval, !executeOnlyOnce);
			registeredWaitHandle.RestartWait();
			return registeredWaitHandle;
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x000E17E5 File Offset: 0x000DF9E5
		private static void NativeOverlappedCallback(IntPtr overlappedPtr)
		{
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIODequeue(overlappedPtr);
			}
			IOCompletionCallbackHelper.PerformSingleIOCompletionCallback(0U, 0U, overlappedPtr);
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x000E1808 File Offset: 0x000DFA08
		[SupportedOSPlatform("windows")]
		public unsafe static bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped)
		{
			if (overlapped == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.overlapped);
			}
			overlapped->InternalLow = (IntPtr)0;
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIOEnqueue(overlapped);
			}
			Action<IntPtr> callBack;
			if ((callBack = WindowsThreadPool.<>O.<0>__NativeOverlappedCallback) == null)
			{
				callBack = (WindowsThreadPool.<>O.<0>__NativeOverlappedCallback = new Action<IntPtr>(WindowsThreadPool.NativeOverlappedCallback));
			}
			return ThreadPool.UnsafeQueueUserWorkItem<IntPtr>(callBack, overlapped, false);
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000E1862 File Offset: 0x000DFA62
		[Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated. Use ThreadPool.BindHandle(SafeHandle) instead.")]
		[SupportedOSPlatform("windows")]
		public static bool BindHandle(IntPtr osHandle)
		{
			throw new PlatformNotSupportedException(SR.Arg_PlatformNotSupported);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000E1862 File Offset: 0x000DFA62
		[SupportedOSPlatform("windows")]
		public static bool BindHandle(SafeHandle osHandle)
		{
			throw new PlatformNotSupportedException(SR.Arg_PlatformNotSupported);
		}

		// Token: 0x04000F05 RID: 3845
		private static readonly int MaxThreadCount = Math.Max(8 * Environment.ProcessorCount, 768);

		// Token: 0x04000F06 RID: 3846
		private static IntPtr s_work;

		// Token: 0x04000F07 RID: 3847
		[ThreadStatic]
		private static WindowsThreadPool.ThreadCountHolder t_threadCountHolder;

		// Token: 0x04000F08 RID: 3848
		private static int s_threadCount;

		// Token: 0x04000F09 RID: 3849
		private static WindowsThreadPool.WorkingThreadCounter s_workingThreadCounter;

		// Token: 0x04000F0A RID: 3850
		private static readonly ThreadInt64PersistentCounter s_completedWorkItemCounter = new ThreadInt64PersistentCounter();

		// Token: 0x04000F0B RID: 3851
		[ThreadStatic]
		private static object t_completionCountObject;

		// Token: 0x0200046E RID: 1134
		private sealed class ThreadCountHolder
		{
			// Token: 0x060043B0 RID: 17328 RVA: 0x000E1890 File Offset: 0x000DFA90
			internal ThreadCountHolder()
			{
				Interlocked.Increment(ref WindowsThreadPool.s_threadCount);
			}

			// Token: 0x060043B1 RID: 17329 RVA: 0x000E18A4 File Offset: 0x000DFAA4
			~ThreadCountHolder()
			{
				Interlocked.Decrement(ref WindowsThreadPool.s_threadCount);
			}
		}

		// Token: 0x0200046F RID: 1135
		private struct WorkingThreadCounter
		{
			// Token: 0x04000F0C RID: 3852
			private readonly PaddingFor32 pad1;

			// Token: 0x04000F0D RID: 3853
			public volatile int Count;

			// Token: 0x04000F0E RID: 3854
			private readonly PaddingFor32 pad2;
		}

		// Token: 0x02000470 RID: 1136
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000F0F RID: 3855
			public static Action<IntPtr> <0>__NativeOverlappedCallback;
		}
	}
}
