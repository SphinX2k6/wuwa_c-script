using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x02000472 RID: 1138
	internal sealed class PortableThreadPool
	{
		// Token: 0x060043B4 RID: 17332 RVA: 0x000E1904 File Offset: 0x000DFB04
		private static int DetermineThreadPoolThreadTimeoutMs()
		{
			int int32Config = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.ThreadTimeoutMs", "DOTNET_ThreadPool_ThreadTimeoutMs", 20000, true);
			if (int32Config < -1)
			{
				return 20000;
			}
			return int32Config;
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x000E1934 File Offset: 0x000DFB34
		private PortableThreadPool()
		{
			this._minThreads = (PortableThreadPool.HasForcedMinThreads ? PortableThreadPool.ForcedMinWorkerThreads : ((short)Environment.ProcessorCount));
			if (this._minThreads > 32767)
			{
				this._minThreads = short.MaxValue;
			}
			this._maxThreads = (PortableThreadPool.HasForcedMaxThreads ? PortableThreadPool.ForcedMaxWorkerThreads : short.MaxValue);
			if (this._maxThreads > 32767)
			{
				this._maxThreads = short.MaxValue;
			}
			else if (this._maxThreads < this._minThreads)
			{
				this._maxThreads = this._minThreads;
			}
			this._legacy_minIOCompletionThreads = 1;
			this._legacy_maxIOCompletionThreads = 1000;
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolMinMaxThreads((ushort)this._minThreads, (ushort)this._maxThreads, (ushort)this._legacy_minIOCompletionThreads, (ushort)this._legacy_maxIOCompletionThreads, 0);
			}
			this._separated.counts.NumThreadsGoal = this._minThreads;
			this.InitializeIOOnWindows();
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x000E1A66 File Offset: 0x000DFC66
		private static bool HasForcedMinThreads
		{
			get
			{
				return PortableThreadPool.ForcedMinWorkerThreads > 0 && (PortableThreadPool.ForcedMaxWorkerThreads <= 0 || PortableThreadPool.ForcedMinWorkerThreads <= PortableThreadPool.ForcedMaxWorkerThreads);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x000E1A8B File Offset: 0x000DFC8B
		private static bool HasForcedMaxThreads
		{
			get
			{
				return PortableThreadPool.ForcedMaxWorkerThreads > 0 && (PortableThreadPool.ForcedMinWorkerThreads <= 0 || PortableThreadPool.ForcedMinWorkerThreads <= PortableThreadPool.ForcedMaxWorkerThreads);
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x000E1AB0 File Offset: 0x000DFCB0
		public bool SetMinThreads(int workerThreads, int ioCompletionThreads)
		{
			if (workerThreads < 0 || ioCompletionThreads < 0)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			this._threadAdjustmentLock.Acquire();
			try
			{
				if (workerThreads > (int)this._maxThreads)
				{
					return false;
				}
				if (ioCompletionThreads > (int)this._legacy_maxIOCompletionThreads)
				{
					return false;
				}
				if (PortableThreadPool.HasForcedMinThreads && workerThreads != (int)PortableThreadPool.ForcedMinWorkerThreads)
				{
					return false;
				}
				this._legacy_minIOCompletionThreads = (short)Math.Max(1, ioCompletionThreads);
				short num = (short)Math.Max(1, workerThreads);
				if (num == this._minThreads)
				{
					return true;
				}
				this._minThreads = num;
				if (this._numBlockedThreads > 0)
				{
					if (this._pendingBlockingAdjustment != PortableThreadPool.PendingBlockingAdjustment.Immediately)
					{
						this._pendingBlockingAdjustment = PortableThreadPool.PendingBlockingAdjustment.Immediately;
						flag2 = true;
					}
				}
				else if (this._separated.counts.NumThreadsGoal < num)
				{
					this._separated.counts.InterlockedSetNumThreadsGoal(num);
					if (this._separated.numRequestedWorkers > 0)
					{
						flag = true;
					}
				}
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolMinMaxThreads((ushort)this._minThreads, (ushort)this._maxThreads, (ushort)this._legacy_minIOCompletionThreads, (ushort)this._legacy_maxIOCompletionThreads, 0);
				}
			}
			finally
			{
				this._threadAdjustmentLock.Release();
			}
			if (flag)
			{
				PortableThreadPool.WorkerThread.MaybeAddWorkingWorker(this);
			}
			else if (flag2)
			{
				PortableThreadPool.GateThread.Wake(this);
			}
			return true;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x000E1BF8 File Offset: 0x000DFDF8
		public void GetMinThreads(out int workerThreads, out int ioCompletionThreads)
		{
			workerThreads = (int)Volatile.Read(ref this._minThreads);
			ioCompletionThreads = (int)this._legacy_minIOCompletionThreads;
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x000E1C10 File Offset: 0x000DFE10
		public bool SetMaxThreads(int workerThreads, int ioCompletionThreads)
		{
			if (workerThreads <= 0 || ioCompletionThreads <= 0)
			{
				return false;
			}
			this._threadAdjustmentLock.Acquire();
			bool result;
			try
			{
				if (workerThreads < (int)this._minThreads)
				{
					result = false;
				}
				else if (ioCompletionThreads < (int)this._legacy_minIOCompletionThreads)
				{
					result = false;
				}
				else if (PortableThreadPool.HasForcedMaxThreads && workerThreads != (int)PortableThreadPool.ForcedMaxWorkerThreads)
				{
					result = false;
				}
				else
				{
					this._legacy_maxIOCompletionThreads = (short)Math.Min(ioCompletionThreads, 32767);
					short num = (short)Math.Min(workerThreads, 32767);
					if (num == this._maxThreads)
					{
						result = true;
					}
					else
					{
						this._maxThreads = num;
						if (this._separated.counts.NumThreadsGoal > num)
						{
							this._separated.counts.InterlockedSetNumThreadsGoal(num);
						}
						if (NativeRuntimeEventSource.Log.IsEnabled())
						{
							NativeRuntimeEventSource.Log.ThreadPoolMinMaxThreads((ushort)this._minThreads, (ushort)this._maxThreads, (ushort)this._legacy_minIOCompletionThreads, (ushort)this._legacy_maxIOCompletionThreads, 0);
						}
						result = true;
					}
				}
			}
			finally
			{
				this._threadAdjustmentLock.Release();
			}
			return result;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x000E1D14 File Offset: 0x000DFF14
		public void GetMaxThreads(out int workerThreads, out int ioCompletionThreads)
		{
			workerThreads = (int)Volatile.Read(ref this._maxThreads);
			ioCompletionThreads = (int)this._legacy_maxIOCompletionThreads;
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x000E1D2C File Offset: 0x000DFF2C
		public void GetAvailableThreads(out int workerThreads, out int ioCompletionThreads)
		{
			PortableThreadPool.ThreadCounts threadCounts = this._separated.counts.VolatileRead();
			workerThreads = Math.Max(0, (int)(this._maxThreads - threadCounts.NumProcessingWork));
			ioCompletionThreads = (int)this._legacy_maxIOCompletionThreads;
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x000E1D68 File Offset: 0x000DFF68
		public int ThreadCount
		{
			get
			{
				return (int)this._separated.counts.VolatileRead().NumExistingThreads;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x000E1D8D File Offset: 0x000DFF8D
		public long CompletedWorkItemCount
		{
			get
			{
				return this._completionCounter.Count;
			}
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x000E1D9A File Offset: 0x000DFF9A
		public object GetOrCreateThreadLocalCompletionCountObject()
		{
			return PortableThreadPool.t_completionCountObject ?? this.CreateThreadLocalCompletionCountObject();
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x000E1DAB File Offset: 0x000DFFAB
		[MethodImpl(MethodImplOptions.NoInlining)]
		private object CreateThreadLocalCompletionCountObject()
		{
			return PortableThreadPool.t_completionCountObject = this._completionCounter.CreateThreadLocalCountObject();
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x000E1DBE File Offset: 0x000DFFBE
		private void NotifyWorkItemProgress(object threadLocalCompletionCountObject, int currentTimeMs)
		{
			ThreadInt64PersistentCounter.Increment(threadLocalCompletionCountObject);
			this._separated.lastDequeueTime = currentTimeMs;
			if (this.ShouldAdjustMaxWorkersActive(currentTimeMs))
			{
				this.AdjustMaxWorkersActive();
			}
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x000E1DE1 File Offset: 0x000DFFE1
		internal void NotifyWorkItemProgress()
		{
			this.NotifyWorkItemProgress(this.GetOrCreateThreadLocalCompletionCountObject(), Environment.TickCount);
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
		internal bool NotifyWorkItemComplete(object threadLocalCompletionCountObject, int currentTimeMs)
		{
			this.NotifyWorkItemProgress(threadLocalCompletionCountObject, currentTimeMs);
			return !PortableThreadPool.WorkerThread.ShouldStopProcessingWorkNow(this);
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x000E1E08 File Offset: 0x000E0008
		private void AdjustMaxWorkersActive()
		{
			LowLevelLock threadAdjustmentLock = this._threadAdjustmentLock;
			if (!threadAdjustmentLock.TryAcquire())
			{
				return;
			}
			bool flag = false;
			try
			{
				PortableThreadPool.ThreadCounts counts = this._separated.counts;
				if (counts.NumProcessingWork > counts.NumThreadsGoal || this._pendingBlockingAdjustment != PortableThreadPool.PendingBlockingAdjustment.None)
				{
					return;
				}
				long timestamp = Stopwatch.GetTimestamp();
				double totalSeconds = Stopwatch.GetElapsedTime(this._currentSampleStartTime, timestamp).TotalSeconds;
				if (totalSeconds * 1000.0 >= (double)(this._threadAdjustmentIntervalMs / 2))
				{
					int tickCount = Environment.TickCount;
					int num = (int)this._completionCounter.Count;
					int numCompletions = num - this._separated.priorCompletionCount;
					short numThreadsGoal = counts.NumThreadsGoal;
					ValueTuple<int, int> valueTuple = PortableThreadPool.HillClimbing.ThreadPoolHillClimber.Update((int)numThreadsGoal, totalSeconds, numCompletions);
					int item = valueTuple.Item1;
					this._threadAdjustmentIntervalMs = valueTuple.Item2;
					if (numThreadsGoal != (short)item)
					{
						this._separated.counts.InterlockedSetNumThreadsGoal((short)item);
						if (item > (int)numThreadsGoal)
						{
							flag = true;
						}
					}
					this._separated.priorCompletionCount = num;
					this._separated.nextCompletedWorkRequestsTime = tickCount + this._threadAdjustmentIntervalMs;
					Volatile.Write(ref this._separated.priorCompletedWorkRequestsTime, tickCount);
					this._currentSampleStartTime = timestamp;
				}
			}
			finally
			{
				threadAdjustmentLock.Release();
			}
			if (flag)
			{
				PortableThreadPool.WorkerThread.MaybeAddWorkingWorker(this);
			}
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x000E1F68 File Offset: 0x000E0168
		private bool ShouldAdjustMaxWorkersActive(int currentTimeMs)
		{
			if (PortableThreadPool.HillClimbing.IsDisabled)
			{
				return false;
			}
			int num = Volatile.Read(ref this._separated.priorCompletedWorkRequestsTime);
			uint num2 = (uint)(this._separated.nextCompletedWorkRequestsTime - num);
			if (currentTimeMs - num < (int)num2)
			{
				return false;
			}
			PortableThreadPool.ThreadCounts counts = this._separated.counts;
			return counts.NumProcessingWork <= counts.NumThreadsGoal && this._pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.None;
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x000E1FCC File Offset: 0x000E01CC
		internal void RequestWorker()
		{
			Interlocked.Increment(ref this._separated.numRequestedWorkers);
			PortableThreadPool.WorkerThread.MaybeAddWorkingWorker(this);
			PortableThreadPool.GateThread.EnsureRunning(this);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x000E1FEC File Offset: 0x000E01EC
		private bool OnGen2GCCallback()
		{
			GCMemoryInfo gcmemoryInfo = GC.GetGCMemoryInfo();
			this._memoryLimitBytes = gcmemoryInfo.HighMemoryLoadThresholdBytes;
			this._memoryUsageBytes = Math.Min(gcmemoryInfo.MemoryLoadBytes, gcmemoryInfo.HighMemoryLoadThresholdBytes);
			return true;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x000E2028 File Offset: 0x000E0228
		internal static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, bool flowExecutionContext)
		{
			ArgumentNullException.ThrowIfNull(waitObject, "waitObject");
			ArgumentNullException.ThrowIfNull(callBack, "callBack");
			RegisteredWaitHandle registeredWaitHandle = new RegisteredWaitHandle(waitObject, new _ThreadPoolWaitOrTimerCallback(callBack, state, flowExecutionContext), (int)millisecondsTimeOutInterval, !executeOnlyOnce);
			PortableThreadPool.ThreadPoolInstance.RegisterWaitHandle(registeredWaitHandle);
			return registeredWaitHandle;
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x000E206D File Offset: 0x000E026D
		public short MinThreadsGoal
		{
			get
			{
				return Math.Min(this._separated.counts.NumThreadsGoal, this.TargetThreadsGoalForBlockingAdjustment);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x000E208A File Offset: 0x000E028A
		private short TargetThreadsGoalForBlockingAdjustment
		{
			get
			{
				if (this._numBlockedThreads > 0)
				{
					return (short)Math.Min((ushort)(this._minThreads + this._numBlockedThreads), (ushort)this._maxThreads);
				}
				return this._minThreads;
			}
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x000E20B8 File Offset: 0x000E02B8
		public bool NotifyThreadBlocked()
		{
			if (!PortableThreadPool.BlockingConfig.IsCooperativeBlockingEnabled || !Thread.CurrentThread.IsThreadPoolThread)
			{
				return false;
			}
			bool flag = false;
			this._threadAdjustmentLock.Acquire();
			try
			{
				this._numBlockedThreads += 1;
				if (this._pendingBlockingAdjustment != PortableThreadPool.PendingBlockingAdjustment.WithDelayIfNecessary && this._separated.counts.NumThreadsGoal < this.TargetThreadsGoalForBlockingAdjustment)
				{
					if (this._pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.None)
					{
						flag = true;
					}
					this._pendingBlockingAdjustment = PortableThreadPool.PendingBlockingAdjustment.WithDelayIfNecessary;
				}
			}
			finally
			{
				this._threadAdjustmentLock.Release();
			}
			if (flag)
			{
				PortableThreadPool.GateThread.Wake(this);
			}
			return true;
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x000E2150 File Offset: 0x000E0350
		public void NotifyThreadUnblocked()
		{
			bool flag = false;
			this._threadAdjustmentLock.Acquire();
			try
			{
				this._numBlockedThreads -= 1;
				if (this._pendingBlockingAdjustment != PortableThreadPool.PendingBlockingAdjustment.Immediately && this._numThreadsAddedDueToBlocking > 0 && this._separated.counts.NumThreadsGoal > this.TargetThreadsGoalForBlockingAdjustment)
				{
					flag = true;
					this._pendingBlockingAdjustment = PortableThreadPool.PendingBlockingAdjustment.Immediately;
				}
			}
			finally
			{
				this._threadAdjustmentLock.Release();
			}
			if (flag)
			{
				PortableThreadPool.GateThread.Wake(this);
			}
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x000E21D4 File Offset: 0x000E03D4
		private uint PerformBlockingAdjustment(bool previousDelayElapsed)
		{
			this._threadAdjustmentLock.Acquire();
			bool flag;
			uint result;
			try
			{
				result = this.PerformBlockingAdjustment(previousDelayElapsed, out flag);
			}
			finally
			{
				this._threadAdjustmentLock.Release();
			}
			if (flag)
			{
				PortableThreadPool.WorkerThread.MaybeAddWorkingWorker(this);
			}
			return result;
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x000E2220 File Offset: 0x000E0420
		private uint PerformBlockingAdjustment(bool previousDelayElapsed, out bool addWorker)
		{
			this._pendingBlockingAdjustment = PortableThreadPool.PendingBlockingAdjustment.None;
			addWorker = false;
			short targetThreadsGoalForBlockingAdjustment = this.TargetThreadsGoalForBlockingAdjustment;
			PortableThreadPool.ThreadCounts threadCounts = this._separated.counts;
			short num = threadCounts.NumThreadsGoal;
			if (num == targetThreadsGoalForBlockingAdjustment)
			{
				return 0U;
			}
			if (num <= targetThreadsGoalForBlockingAdjustment)
			{
				short num2 = (short)Math.Min((ushort)(this._minThreads + PortableThreadPool.BlockingConfig.ThreadsToAddWithoutDelay), (ushort)this._maxThreads);
				short val = Math.Max(num2, Math.Min(threadCounts.NumExistingThreads, this._maxThreads));
				short num3 = Math.Min(targetThreadsGoalForBlockingAdjustment, val);
				short num4;
				if (num < num3)
				{
					num4 = num3;
				}
				else
				{
					if (!previousDelayElapsed)
					{
						goto IL_1A6;
					}
					num4 = num + 1;
				}
				if (num4 > threadCounts.NumExistingThreads && !PortableThreadPool.BlockingConfig.IgnoreMemoryUsage)
				{
					long memoryLimitBytes = this._memoryLimitBytes;
					if (memoryLimitBytes > 0L)
					{
						long num5 = this._memoryUsageBytes + (long)threadCounts.NumExistingThreads * 65536L;
						long num6 = memoryLimitBytes * 8L / 10L;
						if (num5 >= num6)
						{
							return 0U;
						}
						long val2 = (long)threadCounts.NumExistingThreads + (num6 - num5) / 65536L;
						num4 = (short)Math.Min((long)num4, val2);
						if (num4 <= num)
						{
							return 0U;
						}
					}
				}
				this._numThreadsAddedDueToBlocking += num4 - num;
				threadCounts = this._separated.counts.InterlockedSetNumThreadsGoal(num4);
				PortableThreadPool.HillClimbing.ThreadPoolHillClimber.ForceChange((int)num4, PortableThreadPool.HillClimbing.StateOrTransition.CooperativeBlocking);
				if (threadCounts.NumProcessingWork >= num && this._separated.numRequestedWorkers > 0)
				{
					addWorker = true;
				}
				num = num4;
				if (num >= targetThreadsGoalForBlockingAdjustment)
				{
					return 0U;
				}
				IL_1A6:
				this._pendingBlockingAdjustment = PortableThreadPool.PendingBlockingAdjustment.WithDelayIfNecessary;
				return Math.Min((uint)(1 + (num - num2) / PortableThreadPool.BlockingConfig.ThreadsPerDelayStep) * PortableThreadPool.BlockingConfig.DelayStepMs, PortableThreadPool.BlockingConfig.MaxDelayMs);
			}
			if (this._numThreadsAddedDueToBlocking <= 0)
			{
				return 0U;
			}
			short num7 = Math.Min(num - targetThreadsGoalForBlockingAdjustment, this._numThreadsAddedDueToBlocking);
			this._numThreadsAddedDueToBlocking -= num7;
			num -= num7;
			this._separated.counts.InterlockedSetNumThreadsGoal(num);
			PortableThreadPool.HillClimbing.ThreadPoolHillClimber.ForceChange((int)num, PortableThreadPool.HillClimbing.StateOrTransition.CooperativeBlocking);
			return 0U;
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x000E23F8 File Offset: 0x000E05F8
		private static short DetermineIOCompletionPortCount()
		{
			short int16Config = AppContextConfigHelper.GetInt16Config("System.Threading.ThreadPool.IOCompletionPortCount", "DOTNET_ThreadPool_IOCompletionPortCount", 1, false);
			if (int16Config != 0)
			{
				return Math.Min(int16Config, 1024);
			}
			return 1;
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x000E2428 File Offset: 0x000E0628
		private static int DetermineIOCompletionPollerCount()
		{
			uint num;
			int num2;
			if (uint.TryParse(Environment.GetEnvironmentVariable("DOTNET_SYSTEM_NET_SOCKETS_THREAD_COUNT"), out num) && num != 0U)
			{
				num2 = (int)Math.Min(num, 32767U);
			}
			else if (PortableThreadPool.UnsafeInlineIOCompletionCallbacks)
			{
				num2 = Environment.ProcessorCount;
			}
			else
			{
				int int32Config = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.ProcessorsPerIOPollerThread", 12, false);
				num2 = (Environment.ProcessorCount - 1) / int32Config + 1;
			}
			if (PortableThreadPool.IOCompletionPortCount == 1)
			{
				return num2;
			}
			if (num2 <= (int)PortableThreadPool.IOCompletionPortCount)
			{
				return (int)PortableThreadPool.IOCompletionPortCount;
			}
			int num3 = num2 % (int)PortableThreadPool.IOCompletionPortCount;
			if (num3 != 0)
			{
				num2 += (int)PortableThreadPool.IOCompletionPortCount - num3;
			}
			return num2;
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x000E24B0 File Offset: 0x000E06B0
		private void InitializeIOOnWindows()
		{
			int numConcurrentThreads = PortableThreadPool.IOCompletionPollerCount / (int)PortableThreadPool.IOCompletionPortCount;
			for (int i = 0; i < (int)PortableThreadPool.IOCompletionPortCount; i++)
			{
				this._ioPorts[i] = PortableThreadPool.CreateIOCompletionPort(numConcurrentThreads);
			}
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x000E24E8 File Offset: 0x000E06E8
		private static IntPtr CreateIOCompletionPort(int numConcurrentThreads)
		{
			IntPtr intPtr = Interop.Kernel32.CreateIoCompletionPort(new IntPtr(-1), IntPtr.Zero, UIntPtr.Zero, numConcurrentThreads);
			if (intPtr == 0)
			{
				int hrforLastWin32Error = Marshal.GetHRForLastWin32Error();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Failed to create an IO completion port. HR: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(hrforLastWin32Error);
				Environment.FailFast(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return intPtr;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x000E2540 File Offset: 0x000E0740
		public void RegisterForIOCompletionNotifications(IntPtr handle)
		{
			if (this._ioCompletionPollers == null)
			{
				this.EnsureIOCompletionPollers();
			}
			uint num = (PortableThreadPool.IOCompletionPortCount == 1) ? 0U : (Interlocked.Increment(ref this._ioPortSelectorForRegister) % (uint)PortableThreadPool.IOCompletionPortCount);
			IntPtr existingCompletionPort = this._ioPorts[(int)num];
			if (Interop.Kernel32.CreateIoCompletionPort(handle, existingCompletionPort, UIntPtr.Zero, 0) == 0)
			{
				ThrowHelper.ThrowApplicationException(Marshal.GetHRForLastWin32Error());
			}
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x000E259C File Offset: 0x000E079C
		public unsafe void QueueNativeOverlapped(NativeOverlapped* nativeOverlapped)
		{
			if (this._ioCompletionPollers == null)
			{
				this.EnsureIOCompletionPollers();
			}
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIOEnqueue(nativeOverlapped);
			}
			uint num = (PortableThreadPool.IOCompletionPortCount == 1) ? 0U : (Interlocked.Increment(ref this._ioPortSelectorForQueue) % (uint)PortableThreadPool.IOCompletionPortCount);
			if (!Interop.Kernel32.PostQueuedCompletionStatus(this._ioPorts[(int)num], 0U, UIntPtr.Zero, nativeOverlapped))
			{
				ThrowHelper.ThrowApplicationException(Marshal.GetHRForLastWin32Error());
			}
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x000E260C File Offset: 0x000E080C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnsureIOCompletionPollers()
		{
			this._threadAdjustmentLock.Acquire();
			try
			{
				if (this._ioCompletionPollers == null)
				{
					PortableThreadPool.IOCompletionPoller[] array = new PortableThreadPool.IOCompletionPoller[PortableThreadPool.IOCompletionPollerCount];
					for (int i = 0; i < PortableThreadPool.IOCompletionPollerCount; i++)
					{
						array[i] = new PortableThreadPool.IOCompletionPoller(this._ioPorts[i % (int)PortableThreadPool.IOCompletionPortCount]);
					}
					this._ioCompletionPollers = array;
				}
			}
			catch (Exception exception)
			{
				Environment.FailFast("Failed to initialize IO completion pollers.", exception);
			}
			finally
			{
				this._threadAdjustmentLock.Release();
			}
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x000E26A0 File Offset: 0x000E08A0
		internal void RegisterWaitHandle(RegisteredWaitHandle handle)
		{
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIOEnqueue(handle);
			}
			this._waitThreadLock.Acquire();
			try
			{
				PortableThreadPool.WaitThreadNode waitThreadNode;
				if ((waitThreadNode = this._waitThreadsHead) == null)
				{
					waitThreadNode = (this._waitThreadsHead = new PortableThreadPool.WaitThreadNode(new PortableThreadPool.WaitThread()));
				}
				PortableThreadPool.WaitThreadNode waitThreadNode2 = waitThreadNode;
				while (!waitThreadNode2.Thread.RegisterWaitHandle(handle))
				{
					PortableThreadPool.WaitThreadNode waitThreadNode3 = waitThreadNode2;
					waitThreadNode2 = waitThreadNode2.Next;
					if (waitThreadNode2 == null)
					{
						waitThreadNode3.Next = new PortableThreadPool.WaitThreadNode(new PortableThreadPool.WaitThread());
						waitThreadNode3.Next.Thread.RegisterWaitHandle(handle);
						break;
					}
				}
			}
			finally
			{
				this._waitThreadLock.Release();
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x000E274C File Offset: 0x000E094C
		internal static void CompleteWait(RegisteredWaitHandle handle, bool timedOut)
		{
			if (NativeRuntimeEventSource.Log.IsEnabled())
			{
				NativeRuntimeEventSource.Log.ThreadPoolIODequeue(handle);
			}
			handle.PerformCallback(timedOut);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x000E276C File Offset: 0x000E096C
		private bool TryRemoveWaitThread(PortableThreadPool.WaitThread thread)
		{
			this._waitThreadLock.Acquire();
			try
			{
				if (thread.AnyUserWaits)
				{
					return false;
				}
				this.RemoveWaitThread(thread);
			}
			finally
			{
				this._waitThreadLock.Release();
			}
			return true;
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000E27B8 File Offset: 0x000E09B8
		private void RemoveWaitThread(PortableThreadPool.WaitThread thread)
		{
			PortableThreadPool.WaitThreadNode waitThreadNode = this._waitThreadsHead;
			if (waitThreadNode.Thread == thread)
			{
				this._waitThreadsHead = waitThreadNode.Next;
				return;
			}
			PortableThreadPool.WaitThreadNode waitThreadNode2;
			do
			{
				waitThreadNode2 = waitThreadNode;
				waitThreadNode = waitThreadNode.Next;
			}
			while (waitThreadNode != null && waitThreadNode.Thread != thread);
			if (waitThreadNode != null)
			{
				waitThreadNode2.Next = waitThreadNode.Next;
			}
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x000E2808 File Offset: 0x000E0A08
		public void ReportThreadStatus(bool isProcessingUserCallback)
		{
			PortableThreadPool.CountsOfThreadsProcessingUserCallbacks countsOfThreadsProcessingUserCallbacks = this._countsOfThreadsProcessingUserCallbacks;
			for (;;)
			{
				PortableThreadPool.CountsOfThreadsProcessingUserCallbacks newCounts = countsOfThreadsProcessingUserCallbacks;
				if (isProcessingUserCallback)
				{
					newCounts.IncrementCurrent();
				}
				else
				{
					newCounts.DecrementCurrent();
				}
				PortableThreadPool.CountsOfThreadsProcessingUserCallbacks countsOfThreadsProcessingUserCallbacks2 = this._countsOfThreadsProcessingUserCallbacks.InterlockedCompareExchange(newCounts, countsOfThreadsProcessingUserCallbacks);
				if (countsOfThreadsProcessingUserCallbacks2 == countsOfThreadsProcessingUserCallbacks)
				{
					break;
				}
				countsOfThreadsProcessingUserCallbacks = countsOfThreadsProcessingUserCallbacks2;
			}
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x000E284C File Offset: 0x000E0A4C
		private short GetAndResetHighWatermarkCountOfThreadsProcessingUserCallbacks()
		{
			PortableThreadPool.CountsOfThreadsProcessingUserCallbacks countsOfThreadsProcessingUserCallbacks = this._countsOfThreadsProcessingUserCallbacks;
			PortableThreadPool.CountsOfThreadsProcessingUserCallbacks countsOfThreadsProcessingUserCallbacks2;
			for (;;)
			{
				PortableThreadPool.CountsOfThreadsProcessingUserCallbacks newCounts = countsOfThreadsProcessingUserCallbacks;
				newCounts.ResetHighWatermark();
				countsOfThreadsProcessingUserCallbacks2 = this._countsOfThreadsProcessingUserCallbacks.InterlockedCompareExchange(newCounts, countsOfThreadsProcessingUserCallbacks);
				if (countsOfThreadsProcessingUserCallbacks2 == countsOfThreadsProcessingUserCallbacks || countsOfThreadsProcessingUserCallbacks2.HighWatermark == countsOfThreadsProcessingUserCallbacks2.Current)
				{
					break;
				}
				countsOfThreadsProcessingUserCallbacks = countsOfThreadsProcessingUserCallbacks2;
			}
			return countsOfThreadsProcessingUserCallbacks2.HighWatermark;
		}

		// Token: 0x04000F12 RID: 3858
		private static readonly short ForcedMinWorkerThreads = AppContextConfigHelper.GetInt16Config("System.Threading.ThreadPool.MinThreads", 0, false);

		// Token: 0x04000F13 RID: 3859
		private static readonly short ForcedMaxWorkerThreads = AppContextConfigHelper.GetInt16Config("System.Threading.ThreadPool.MaxThreads", 0, false);

		// Token: 0x04000F14 RID: 3860
		private static readonly bool UnsafeInlineIOCompletionCallbacks = Environment.GetEnvironmentVariable("DOTNET_SYSTEM_NET_SOCKETS_INLINE_COMPLETIONS") == "1";

		// Token: 0x04000F15 RID: 3861
		private static readonly short IOCompletionPortCount = PortableThreadPool.DetermineIOCompletionPortCount();

		// Token: 0x04000F16 RID: 3862
		private static readonly int IOCompletionPollerCount = PortableThreadPool.DetermineIOCompletionPollerCount();

		// Token: 0x04000F17 RID: 3863
		private static readonly int ThreadPoolThreadTimeoutMs = PortableThreadPool.DetermineThreadPoolThreadTimeoutMs();

		// Token: 0x04000F18 RID: 3864
		[ThreadStatic]
		private static object t_completionCountObject;

		// Token: 0x04000F19 RID: 3865
		public static readonly PortableThreadPool ThreadPoolInstance = new PortableThreadPool();

		// Token: 0x04000F1A RID: 3866
		private int _cpuUtilization;

		// Token: 0x04000F1B RID: 3867
		private short _minThreads;

		// Token: 0x04000F1C RID: 3868
		private short _maxThreads;

		// Token: 0x04000F1D RID: 3869
		private short _legacy_minIOCompletionThreads;

		// Token: 0x04000F1E RID: 3870
		private short _legacy_maxIOCompletionThreads;

		// Token: 0x04000F1F RID: 3871
		private int _numThreadsBeingKeptAlive;

		// Token: 0x04000F20 RID: 3872
		private long _currentSampleStartTime;

		// Token: 0x04000F21 RID: 3873
		private readonly ThreadInt64PersistentCounter _completionCounter = new ThreadInt64PersistentCounter();

		// Token: 0x04000F22 RID: 3874
		private int _threadAdjustmentIntervalMs;

		// Token: 0x04000F23 RID: 3875
		private short _numBlockedThreads;

		// Token: 0x04000F24 RID: 3876
		private short _numThreadsAddedDueToBlocking;

		// Token: 0x04000F25 RID: 3877
		private PortableThreadPool.PendingBlockingAdjustment _pendingBlockingAdjustment;

		// Token: 0x04000F26 RID: 3878
		private long _memoryUsageBytes;

		// Token: 0x04000F27 RID: 3879
		private long _memoryLimitBytes;

		// Token: 0x04000F28 RID: 3880
		private readonly LowLevelLock _threadAdjustmentLock = new LowLevelLock();

		// Token: 0x04000F29 RID: 3881
		private PortableThreadPool.CacheLineSeparated _separated;

		// Token: 0x04000F2A RID: 3882
		private readonly IntPtr[] _ioPorts = new IntPtr[(int)PortableThreadPool.IOCompletionPortCount];

		// Token: 0x04000F2B RID: 3883
		private uint _ioPortSelectorForRegister = uint.MaxValue;

		// Token: 0x04000F2C RID: 3884
		private uint _ioPortSelectorForQueue = uint.MaxValue;

		// Token: 0x04000F2D RID: 3885
		private PortableThreadPool.IOCompletionPoller[] _ioCompletionPollers;

		// Token: 0x04000F2E RID: 3886
		private PortableThreadPool.WaitThreadNode _waitThreadsHead;

		// Token: 0x04000F2F RID: 3887
		private readonly LowLevelLock _waitThreadLock = new LowLevelLock();

		// Token: 0x04000F30 RID: 3888
		private PortableThreadPool.CountsOfThreadsProcessingUserCallbacks _countsOfThreadsProcessingUserCallbacks;

		// Token: 0x02000473 RID: 1139
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		private struct CacheLineSeparated
		{
			// Token: 0x04000F31 RID: 3889
			[FieldOffset(64)]
			public PortableThreadPool.ThreadCounts counts;

			// Token: 0x04000F32 RID: 3890
			[FieldOffset(128)]
			public int lastDequeueTime;

			// Token: 0x04000F33 RID: 3891
			[FieldOffset(192)]
			public int priorCompletionCount;

			// Token: 0x04000F34 RID: 3892
			[FieldOffset(196)]
			public int priorCompletedWorkRequestsTime;

			// Token: 0x04000F35 RID: 3893
			[FieldOffset(200)]
			public int nextCompletedWorkRequestsTime;

			// Token: 0x04000F36 RID: 3894
			[FieldOffset(256)]
			public volatile int numRequestedWorkers;

			// Token: 0x04000F37 RID: 3895
			[FieldOffset(260)]
			public int gateThreadRunningState;
		}

		// Token: 0x02000474 RID: 1140
		private enum PendingBlockingAdjustment : byte
		{
			// Token: 0x04000F39 RID: 3897
			None,
			// Token: 0x04000F3A RID: 3898
			Immediately,
			// Token: 0x04000F3B RID: 3899
			WithDelayIfNecessary
		}

		// Token: 0x02000475 RID: 1141
		private static class BlockingConfig
		{
			// Token: 0x060043DD RID: 17373 RVA: 0x000E290C File Offset: 0x000E0B0C
			static BlockingConfig()
			{
				int int32Config = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.Blocking.ThreadsToAddWithoutDelay_ProcCountFactor", 1, false);
				int num = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.Blocking.ThreadsPerDelayStep_ProcCountFactor", 1, false);
				PortableThreadPool.BlockingConfig.DelayStepMs = (uint)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.Blocking.DelayStepMs", 25, false);
				PortableThreadPool.BlockingConfig.MaxDelayMs = (uint)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.Blocking.MaxDelayMs", 250, false);
				int processorCount = Environment.ProcessorCount;
				PortableThreadPool.BlockingConfig.ThreadsToAddWithoutDelay = (short)(processorCount * int32Config);
				if (PortableThreadPool.BlockingConfig.ThreadsToAddWithoutDelay > 32767 || (int)PortableThreadPool.BlockingConfig.ThreadsToAddWithoutDelay / processorCount != int32Config)
				{
					PortableThreadPool.BlockingConfig.ThreadsToAddWithoutDelay = short.MaxValue;
				}
				num = Math.Max(1, num);
				short num2 = short.MaxValue - PortableThreadPool.BlockingConfig.ThreadsToAddWithoutDelay;
				PortableThreadPool.BlockingConfig.ThreadsPerDelayStep = (short)(processorCount * num);
				if (PortableThreadPool.BlockingConfig.ThreadsPerDelayStep > num2 || (int)PortableThreadPool.BlockingConfig.ThreadsPerDelayStep / processorCount != num)
				{
					PortableThreadPool.BlockingConfig.ThreadsPerDelayStep = num2;
				}
				PortableThreadPool.BlockingConfig.MaxDelayMs = Math.Max(1U, Math.Min(PortableThreadPool.BlockingConfig.MaxDelayMs, 500U));
				PortableThreadPool.BlockingConfig.DelayStepMs = Math.Max(1U, Math.Min(PortableThreadPool.BlockingConfig.DelayStepMs, PortableThreadPool.BlockingConfig.MaxDelayMs));
			}

			// Token: 0x04000F3C RID: 3900
			public static readonly bool IsCooperativeBlockingEnabled = AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.Blocking.CooperativeBlocking", true);

			// Token: 0x04000F3D RID: 3901
			public static readonly bool IgnoreMemoryUsage = AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.Blocking.IgnoreMemoryUsage", false);

			// Token: 0x04000F3E RID: 3902
			public static readonly short ThreadsToAddWithoutDelay;

			// Token: 0x04000F3F RID: 3903
			public static readonly short ThreadsPerDelayStep;

			// Token: 0x04000F40 RID: 3904
			public static readonly uint DelayStepMs;

			// Token: 0x04000F41 RID: 3905
			public static readonly uint MaxDelayMs;
		}

		// Token: 0x02000476 RID: 1142
		private static class GateThread
		{
			// Token: 0x060043DE RID: 17374 RVA: 0x000E2A14 File Offset: 0x000E0C14
			private static void GateThreadStart()
			{
				bool booleanConfig = AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.DisableStarvationDetection", false);
				bool booleanConfig2 = AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.DebugBreakOnWorkerStarvation", false);
				int int32Config = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.CpuUtilizationIntervalMs", "DOTNET_ThreadPool_CpuUtilizationIntervalMs", 1, false);
				PortableThreadPool.CpuUtilizationReader cpuUtilizationReader = default(PortableThreadPool.CpuUtilizationReader);
				int num = 0;
				if (int32Config > 0)
				{
					num = Environment.TickCount;
					int currentUtilization = cpuUtilizationReader.CurrentUtilization;
				}
				PortableThreadPool threadPoolInstance = PortableThreadPool.ThreadPoolInstance;
				LowLevelLock threadAdjustmentLock = threadPoolInstance._threadAdjustmentLock;
				PortableThreadPool.GateThread.DelayHelper delayHelper = default(PortableThreadPool.GateThread.DelayHelper);
				if (PortableThreadPool.BlockingConfig.IsCooperativeBlockingEnabled && !PortableThreadPool.BlockingConfig.IgnoreMemoryUsage)
				{
					threadPoolInstance.OnGen2GCCallback();
					Gen2GcCallback.Register(new Func<bool>(threadPoolInstance.OnGen2GCCallback));
				}
				for (;;)
				{
					PortableThreadPool.GateThread.RunGateThreadEvent.WaitOne();
					int tickCount = Environment.TickCount;
					delayHelper.SetGateActivitiesTime(tickCount);
					for (;;)
					{
						bool wasSignaledToWake = PortableThreadPool.GateThread.DelayEvent.WaitOne((int)delayHelper.GetNextDelay(tickCount));
						tickCount = Environment.TickCount;
						PortableThreadPool.PendingBlockingAdjustment pendingBlockingAdjustment = threadPoolInstance._pendingBlockingAdjustment;
						if (pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.None)
						{
							delayHelper.ClearBlockingAdjustmentDelay();
						}
						else
						{
							bool flag = false;
							if (delayHelper.HasBlockingAdjustmentDelay)
							{
								flag = delayHelper.HasBlockingAdjustmentDelayElapsed(tickCount, wasSignaledToWake);
								if (pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.WithDelayIfNecessary && !flag)
								{
									goto IL_11B;
								}
							}
							uint num2 = threadPoolInstance.PerformBlockingAdjustment(flag);
							if (num2 <= 0U)
							{
								delayHelper.ClearBlockingAdjustmentDelay();
							}
							else
							{
								delayHelper.SetBlockingAdjustmentTimeAndDelay(tickCount, num2);
							}
						}
						IL_11B:
						if (delayHelper.ShouldPerformGateActivities(tickCount, wasSignaledToWake))
						{
							if (ThreadPool.EnableWorkerTracking && NativeRuntimeEventSource.Log.IsEnabled())
							{
								NativeRuntimeEventSource.Log.ThreadPoolWorkingThreadCount((uint)threadPoolInstance.GetAndResetHighWatermarkCountOfThreadsProcessingUserCallbacks(), 0);
							}
							if (int32Config > 0 && threadPoolInstance._pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.None && tickCount - num >= int32Config)
							{
								num = tickCount;
								int currentUtilization2 = cpuUtilizationReader.CurrentUtilization;
								threadPoolInstance._cpuUtilization = currentUtilization2;
							}
							if (!booleanConfig && threadPoolInstance._pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.None && threadPoolInstance._separated.numRequestedWorkers > 0 && PortableThreadPool.GateThread.SufficientDelaySinceLastDequeue(threadPoolInstance))
							{
								bool flag2 = false;
								threadAdjustmentLock.Acquire();
								try
								{
									PortableThreadPool.ThreadCounts threadCounts = threadPoolInstance._separated.counts;
									while (threadCounts.NumProcessingWork < threadPoolInstance._maxThreads && threadCounts.NumProcessingWork >= threadCounts.NumThreadsGoal)
									{
										if (booleanConfig2)
										{
											Debugger.Break();
										}
										PortableThreadPool.ThreadCounts newCounts = threadCounts;
										short num3 = threadCounts.NumProcessingWork + 1;
										newCounts.NumThreadsGoal = num3;
										PortableThreadPool.ThreadCounts threadCounts2 = threadPoolInstance._separated.counts.InterlockedCompareExchange(newCounts, threadCounts);
										if (threadCounts2 == threadCounts)
										{
											PortableThreadPool.HillClimbing.ThreadPoolHillClimber.ForceChange((int)num3, PortableThreadPool.HillClimbing.StateOrTransition.Starvation);
											flag2 = true;
											break;
										}
										threadCounts = threadCounts2;
									}
								}
								finally
								{
									threadAdjustmentLock.Release();
								}
								if (flag2)
								{
									PortableThreadPool.WorkerThread.MaybeAddWorkingWorker(threadPoolInstance);
								}
							}
							if (threadPoolInstance._separated.numRequestedWorkers <= 0 && threadPoolInstance._pendingBlockingAdjustment == PortableThreadPool.PendingBlockingAdjustment.None && Interlocked.Decrement(ref threadPoolInstance._separated.gateThreadRunningState) <= PortableThreadPool.GateThread.GetRunningStateForNumRuns(0))
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060043DF RID: 17375 RVA: 0x000E2CC8 File Offset: 0x000E0EC8
			public static void Wake(PortableThreadPool threadPoolInstance)
			{
				PortableThreadPool.GateThread.DelayEvent.Set();
				PortableThreadPool.GateThread.EnsureRunning(threadPoolInstance);
			}

			// Token: 0x060043E0 RID: 17376 RVA: 0x000E2CDC File Offset: 0x000E0EDC
			private static bool SufficientDelaySinceLastDequeue(PortableThreadPool threadPoolInstance)
			{
				uint num = (uint)(Environment.TickCount - threadPoolInstance._separated.lastDequeueTime);
				uint num2;
				if (threadPoolInstance._cpuUtilization < 80)
				{
					num2 = 500U;
				}
				else
				{
					num2 = (uint)(threadPoolInstance._separated.counts.NumThreadsGoal * 1000);
				}
				return num > num2;
			}

			// Token: 0x060043E1 RID: 17377 RVA: 0x000E2D26 File Offset: 0x000E0F26
			internal static void EnsureRunning(PortableThreadPool threadPoolInstance)
			{
				if (threadPoolInstance._separated.gateThreadRunningState != PortableThreadPool.GateThread.GetRunningStateForNumRuns(2))
				{
					PortableThreadPool.GateThread.EnsureRunningSlow(threadPoolInstance);
				}
			}

			// Token: 0x060043E2 RID: 17378 RVA: 0x000E2D44 File Offset: 0x000E0F44
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void EnsureRunningSlow(PortableThreadPool threadPoolInstance)
			{
				int num = Interlocked.Exchange(ref threadPoolInstance._separated.gateThreadRunningState, PortableThreadPool.GateThread.GetRunningStateForNumRuns(2));
				if (num == PortableThreadPool.GateThread.GetRunningStateForNumRuns(0))
				{
					PortableThreadPool.GateThread.RunGateThreadEvent.Set();
					return;
				}
				if ((num & 4) == 0)
				{
					PortableThreadPool.GateThread.CreateGateThread();
				}
			}

			// Token: 0x060043E3 RID: 17379 RVA: 0x000E2D87 File Offset: 0x000E0F87
			private static int GetRunningStateForNumRuns(int numRuns)
			{
				return 4 | numRuns;
			}

			// Token: 0x060043E4 RID: 17380 RVA: 0x000E2D8C File Offset: 0x000E0F8C
			private static void CreateGateThread()
			{
				try
				{
					ThreadStart start;
					if ((start = PortableThreadPool.GateThread.<>O.<0>__GateThreadStart) == null)
					{
						start = (PortableThreadPool.GateThread.<>O.<0>__GateThreadStart = new ThreadStart(PortableThreadPool.GateThread.GateThreadStart));
					}
					new Thread(start, 262144)
					{
						IsThreadPoolThread = true,
						IsBackground = true,
						Name = ".NET TP Gate"
					}.UnsafeStart();
				}
				catch (Exception exception)
				{
					Environment.FailFast("Failed to create the thread pool Gate thread.", exception);
				}
			}

			// Token: 0x04000F42 RID: 3906
			private static readonly AutoResetEvent RunGateThreadEvent = new AutoResetEvent(true);

			// Token: 0x04000F43 RID: 3907
			private static readonly AutoResetEvent DelayEvent = new AutoResetEvent(false);

			// Token: 0x02000477 RID: 1143
			private struct DelayHelper
			{
				// Token: 0x060043E6 RID: 17382 RVA: 0x000E2E14 File Offset: 0x000E1014
				public void SetGateActivitiesTime(int currentTimeMs)
				{
					this._previousGateActivitiesTimeMs = currentTimeMs;
				}

				// Token: 0x060043E7 RID: 17383 RVA: 0x000E2E1D File Offset: 0x000E101D
				public void SetBlockingAdjustmentTimeAndDelay(int currentTimeMs, uint delayMs)
				{
					this._previousBlockingAdjustmentDelayStartTimeMs = currentTimeMs;
					this._previousBlockingAdjustmentDelayMs = delayMs;
				}

				// Token: 0x060043E8 RID: 17384 RVA: 0x000E2E2D File Offset: 0x000E102D
				public void ClearBlockingAdjustmentDelay()
				{
					this._previousBlockingAdjustmentDelayMs = 0U;
				}

				// Token: 0x17000C22 RID: 3106
				// (get) Token: 0x060043E9 RID: 17385 RVA: 0x000E2E36 File Offset: 0x000E1036
				public bool HasBlockingAdjustmentDelay
				{
					get
					{
						return this._previousBlockingAdjustmentDelayMs > 0U;
					}
				}

				// Token: 0x060043EA RID: 17386 RVA: 0x000E2E44 File Offset: 0x000E1044
				public uint GetNextDelay(int currentTimeMs)
				{
					uint num = (uint)(currentTimeMs - this._previousGateActivitiesTimeMs);
					uint num2 = (num < 500U) ? (500U - num) : 1U;
					if (this._previousBlockingAdjustmentDelayMs == 0U)
					{
						this._runGateActivitiesAfterNextDelay = true;
						this._adjustForBlockingAfterNextDelay = false;
						return num2;
					}
					uint num3 = (uint)(currentTimeMs - this._previousBlockingAdjustmentDelayStartTimeMs);
					uint num4 = (num3 < this._previousBlockingAdjustmentDelayMs) ? (this._previousBlockingAdjustmentDelayMs - num3) : 1U;
					uint num5 = Math.Min(num2, num4);
					this._runGateActivitiesAfterNextDelay = (num5 == num2);
					this._adjustForBlockingAfterNextDelay = (num5 == num4);
					return num5;
				}

				// Token: 0x060043EB RID: 17387 RVA: 0x000E2EC4 File Offset: 0x000E10C4
				public bool ShouldPerformGateActivities(int currentTimeMs, bool wasSignaledToWake)
				{
					bool flag = (!wasSignaledToWake && this._runGateActivitiesAfterNextDelay) || currentTimeMs - this._previousGateActivitiesTimeMs >= 500;
					if (flag)
					{
						this.SetGateActivitiesTime(currentTimeMs);
					}
					return flag;
				}

				// Token: 0x060043EC RID: 17388 RVA: 0x000E2EF0 File Offset: 0x000E10F0
				public bool HasBlockingAdjustmentDelayElapsed(int currentTimeMs, bool wasSignaledToWake)
				{
					return (!wasSignaledToWake && this._adjustForBlockingAfterNextDelay) || currentTimeMs - this._previousBlockingAdjustmentDelayStartTimeMs >= (int)this._previousBlockingAdjustmentDelayMs;
				}

				// Token: 0x04000F44 RID: 3908
				private int _previousGateActivitiesTimeMs;

				// Token: 0x04000F45 RID: 3909
				private int _previousBlockingAdjustmentDelayStartTimeMs;

				// Token: 0x04000F46 RID: 3910
				private uint _previousBlockingAdjustmentDelayMs;

				// Token: 0x04000F47 RID: 3911
				private bool _runGateActivitiesAfterNextDelay;

				// Token: 0x04000F48 RID: 3912
				private bool _adjustForBlockingAfterNextDelay;
			}

			// Token: 0x02000478 RID: 1144
			[CompilerGenerated]
			private static class <>O
			{
				// Token: 0x04000F49 RID: 3913
				public static ThreadStart <0>__GateThreadStart;
			}
		}

		// Token: 0x02000479 RID: 1145
		private sealed class HillClimbing
		{
			// Token: 0x060043ED RID: 17389 RVA: 0x000E2F14 File Offset: 0x000E1114
			public HillClimbing()
			{
				this._wavePeriod = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.WavePeriod", 4, false);
				this._maxThreadWaveMagnitude = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.MaxWaveMagnitude", 20, false);
				this._threadMagnitudeMultiplier = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.WaveMagnitudeMultiplier", 100, false) / 100.0;
				this._samplesToMeasure = this._wavePeriod * AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.WaveHistorySize", 8, false);
				this._targetThroughputRatio = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.Bias", 15, false) / 100.0;
				this._targetSignalToNoiseRatio = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.TargetSignalToNoiseRatio", 300, false) / 100.0;
				this._maxChangePerSecond = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.MaxChangePerSecond", 4, false);
				this._maxChangePerSample = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.MaxChangePerSample", 20, false);
				int int32Config = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.SampleIntervalLow", 10, false);
				int int32Config2 = AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.SampleIntervalHigh", 200, false);
				if (int32Config <= int32Config2)
				{
					this._sampleIntervalMsLow = int32Config;
					this._sampleIntervalMsHigh = int32Config2;
				}
				else
				{
					this._sampleIntervalMsLow = 10;
					this._sampleIntervalMsHigh = 200;
				}
				this._throughputErrorSmoothingFactor = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.ErrorSmoothingFactor", 1, false) / 100.0;
				this._gainExponent = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.GainExponent", 200, false) / 100.0;
				this._maxSampleError = (double)AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.HillClimbing.MaxSampleErrorPercent", 15, false) / 100.0;
				this._samples = new double[this._samplesToMeasure];
				this._threadCounts = new double[this._samplesToMeasure];
				this._currentSampleMs = this._randomIntervalGenerator.Next(this._sampleIntervalMsLow, this._sampleIntervalMsHigh + 1);
			}

			// Token: 0x060043EE RID: 17390 RVA: 0x000E30E8 File Offset: 0x000E12E8
			[return: TupleElementNames(new string[]
			{
				"newThreadCount",
				"newSampleMs"
			})]
			public ValueTuple<int, int> Update(int currentThreadCount, double sampleDurationSeconds, int numCompletions)
			{
				if (currentThreadCount != this._lastThreadCount)
				{
					this.ForceChange(currentThreadCount, PortableThreadPool.HillClimbing.StateOrTransition.Initializing);
				}
				this._secondsElapsedSinceLastChange += sampleDurationSeconds;
				this._completionsSinceLastChange += (double)numCompletions;
				sampleDurationSeconds += this._accumulatedSampleDurationSeconds;
				numCompletions += this._accumulatedCompletionCount;
				if (this._totalSamples > 0L && ((double)currentThreadCount - 1.0) / (double)numCompletions >= this._maxSampleError)
				{
					this._accumulatedSampleDurationSeconds = sampleDurationSeconds;
					this._accumulatedCompletionCount = numCompletions;
					return new ValueTuple<int, int>(currentThreadCount, 10);
				}
				this._accumulatedSampleDurationSeconds = 0.0;
				this._accumulatedCompletionCount = 0;
				double num = (double)numCompletions / sampleDurationSeconds;
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolWorkerThreadAdjustmentSample(num, 0);
				}
				int num2 = (int)(this._totalSamples % (long)this._samplesToMeasure);
				this._samples[num2] = num;
				this._threadCounts[num2] = (double)currentThreadCount;
				this._totalSamples += 1L;
				PortableThreadPool.HillClimbing.Complex complex = default(PortableThreadPool.HillClimbing.Complex);
				PortableThreadPool.HillClimbing.Complex lhs = default(PortableThreadPool.HillClimbing.Complex);
				double num3 = 0.0;
				PortableThreadPool.HillClimbing.Complex complex2 = default(PortableThreadPool.HillClimbing.Complex);
				double num4 = 0.0;
				PortableThreadPool.HillClimbing.StateOrTransition state = PortableThreadPool.HillClimbing.StateOrTransition.Warmup;
				int num5 = (int)Math.Min(this._totalSamples - 1L, (long)this._samplesToMeasure) / this._wavePeriod * this._wavePeriod;
				if (num5 > this._wavePeriod)
				{
					double num6 = 0.0;
					double num7 = 0.0;
					for (int i = 0; i < num5; i++)
					{
						num6 += this._samples[(int)(checked((IntPtr)(unchecked((this._totalSamples - (long)num5 + (long)i) % (long)this._samplesToMeasure))))];
						num7 += this._threadCounts[(int)(checked((IntPtr)(unchecked((this._totalSamples - (long)num5 + (long)i) % (long)this._samplesToMeasure))))];
					}
					double num8 = num6 / (double)num5;
					double num9 = num7 / (double)num5;
					if (num8 > 0.0 && num9 > 0.0)
					{
						double period = (double)num5 / ((double)num5 / (double)this._wavePeriod + 1.0);
						double num10 = (double)num5 / ((double)num5 / (double)this._wavePeriod - 1.0);
						lhs = this.GetWaveComponent(this._samples, num5, (double)this._wavePeriod) / num8;
						num3 = (this.GetWaveComponent(this._samples, num5, period) / num8).Abs();
						if (num10 <= (double)num5)
						{
							num3 = Math.Max(num3, (this.GetWaveComponent(this._samples, num5, num10) / num8).Abs());
						}
						complex = this.GetWaveComponent(this._threadCounts, num5, (double)this._wavePeriod) / num9;
						if (this._averageThroughputNoise == 0.0)
						{
							this._averageThroughputNoise = num3;
						}
						else
						{
							this._averageThroughputNoise = this._throughputErrorSmoothingFactor * num3 + (1.0 - this._throughputErrorSmoothingFactor) * this._averageThroughputNoise;
						}
						if (complex.Abs() > 0.0)
						{
							complex2 = (lhs - this._targetThroughputRatio * complex) / complex;
							state = PortableThreadPool.HillClimbing.StateOrTransition.ClimbingMove;
						}
						else
						{
							complex2 = new PortableThreadPool.HillClimbing.Complex(0.0, 0.0);
							state = PortableThreadPool.HillClimbing.StateOrTransition.Stabilizing;
						}
						double num11 = Math.Max(this._averageThroughputNoise, num3);
						if (num11 > 0.0)
						{
							num4 = complex.Abs() / num11 / this._targetSignalToNoiseRatio;
						}
						else
						{
							num4 = 1.0;
						}
					}
				}
				double num12 = Math.Min(1.0, Math.Max(-1.0, complex2.Real));
				num12 *= Math.Min(1.0, Math.Max(0.0, num4));
				double num13 = this._maxChangePerSecond * sampleDurationSeconds;
				num12 = Math.Pow(Math.Abs(num12), this._gainExponent) * (double)((num12 >= 0.0) ? 1 : -1) * num13;
				num12 = Math.Min(num12, this._maxChangePerSample);
				PortableThreadPool threadPoolInstance = PortableThreadPool.ThreadPoolInstance;
				if (num12 > 0.0 && threadPoolInstance._cpuUtilization > 95)
				{
					num12 = 0.0;
				}
				this._currentControlSetting += num12;
				int num14 = (int)(0.5 + this._currentControlSetting * this._averageThroughputNoise * this._targetSignalToNoiseRatio * this._threadMagnitudeMultiplier * 2.0);
				num14 = Math.Min(num14, this._maxThreadWaveMagnitude);
				num14 = Math.Max(num14, 1);
				int maxThreads = (int)threadPoolInstance._maxThreads;
				int minThreadsGoal = (int)threadPoolInstance.MinThreadsGoal;
				this._currentControlSetting = Math.Min((double)(maxThreads - num14), this._currentControlSetting);
				this._currentControlSetting = Math.Max((double)minThreadsGoal, this._currentControlSetting);
				int num15 = (int)(this._currentControlSetting + (double)((long)num14 * (this._totalSamples / (long)(this._wavePeriod / 2) % 2L)));
				num15 = Math.Min(maxThreads, num15);
				num15 = Math.Max(minThreadsGoal, num15);
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolWorkerThreadAdjustmentStats(sampleDurationSeconds, num, complex.Real, lhs.Real, num3, this._averageThroughputNoise, complex2.Real, num4, this._currentControlSetting, (ushort)num14, 0);
				}
				if (num15 != currentThreadCount)
				{
					this.ChangeThreadCount(num15, state);
					this._secondsElapsedSinceLastChange = 0.0;
					this._completionsSinceLastChange = 0.0;
				}
				int item;
				if (complex2.Real < 0.0 && num15 == minThreadsGoal)
				{
					item = (int)(0.5 + (double)this._currentSampleMs * (10.0 * Math.Min(-complex2.Real, 1.0)));
				}
				else
				{
					item = this._currentSampleMs;
				}
				return new ValueTuple<int, int>(num15, item);
			}

			// Token: 0x060043EF RID: 17391 RVA: 0x000E36B4 File Offset: 0x000E18B4
			private void ChangeThreadCount(int newThreadCount, PortableThreadPool.HillClimbing.StateOrTransition state)
			{
				this._lastThreadCount = newThreadCount;
				if (state != PortableThreadPool.HillClimbing.StateOrTransition.CooperativeBlocking)
				{
					this._currentSampleMs = this._randomIntervalGenerator.Next(this._sampleIntervalMsLow, this._sampleIntervalMsHigh + 1);
				}
				double throughput = (this._secondsElapsedSinceLastChange > 0.0) ? (this._completionsSinceLastChange / this._secondsElapsedSinceLastChange) : 0.0;
				this.LogTransition(newThreadCount, throughput, state);
			}

			// Token: 0x060043F0 RID: 17392 RVA: 0x000E3720 File Offset: 0x000E1920
			private void LogTransition(int newThreadCount, double throughput, PortableThreadPool.HillClimbing.StateOrTransition stateOrTransition)
			{
				int num = (this._logStart + this._logSize) % 200;
				if (this._logSize == 200)
				{
					this._logStart = (this._logStart + 1) % 200;
					this._logSize--;
				}
				PortableThreadPool.HillClimbing.LogEntry[] log = this._log;
				int num2 = num;
				log[num2].tickCount = Environment.TickCount;
				log[num2].stateOrTransition = stateOrTransition;
				log[num2].newControlSetting = newThreadCount;
				log[num2].lastHistoryCount = (int)(Math.Min(this._totalSamples, (long)this._samplesToMeasure) / (long)this._wavePeriod) * this._wavePeriod;
				log[num2].lastHistoryMean = (float)throughput;
				this._logSize++;
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolWorkerThreadAdjustmentAdjustment(throughput, (uint)newThreadCount, (NativeRuntimeEventSource.ThreadAdjustmentReasonMap)stateOrTransition, 0);
				}
			}

			// Token: 0x060043F1 RID: 17393 RVA: 0x000E37EC File Offset: 0x000E19EC
			public void ForceChange(int newThreadCount, PortableThreadPool.HillClimbing.StateOrTransition state)
			{
				if (this._lastThreadCount != newThreadCount)
				{
					this._currentControlSetting += (double)(newThreadCount - this._lastThreadCount);
					this.ChangeThreadCount(newThreadCount, state);
				}
			}

			// Token: 0x060043F2 RID: 17394 RVA: 0x000E3818 File Offset: 0x000E1A18
			private PortableThreadPool.HillClimbing.Complex GetWaveComponent(double[] samples, int numSamples, double period)
			{
				double num = 6.283185307179586 / period;
				double num2 = Math.Cos(num);
				double num3 = 2.0 * num2;
				double num4 = 0.0;
				double num5 = 0.0;
				for (int i = 0; i < numSamples; i++)
				{
					double num6 = num3 * num4 - num5 + samples[(int)(checked((IntPtr)(unchecked((this._totalSamples - (long)numSamples + (long)i) % (long)this._samplesToMeasure))))];
					num5 = num4;
					num4 = num6;
				}
				return new PortableThreadPool.HillClimbing.Complex(num4 - num5 * num2, num5 * Math.Sin(num)) / (double)numSamples;
			}

			// Token: 0x04000F4A RID: 3914
			public static readonly bool IsDisabled = AppContextConfigHelper.GetBooleanConfig("System.Threading.ThreadPool.HillClimbing.Disable", false);

			// Token: 0x04000F4B RID: 3915
			public static readonly PortableThreadPool.HillClimbing ThreadPoolHillClimber = new PortableThreadPool.HillClimbing();

			// Token: 0x04000F4C RID: 3916
			private readonly int _wavePeriod;

			// Token: 0x04000F4D RID: 3917
			private readonly int _samplesToMeasure;

			// Token: 0x04000F4E RID: 3918
			private readonly double _targetThroughputRatio;

			// Token: 0x04000F4F RID: 3919
			private readonly double _targetSignalToNoiseRatio;

			// Token: 0x04000F50 RID: 3920
			private readonly double _maxChangePerSecond;

			// Token: 0x04000F51 RID: 3921
			private readonly double _maxChangePerSample;

			// Token: 0x04000F52 RID: 3922
			private readonly int _maxThreadWaveMagnitude;

			// Token: 0x04000F53 RID: 3923
			private readonly int _sampleIntervalMsLow;

			// Token: 0x04000F54 RID: 3924
			private readonly double _threadMagnitudeMultiplier;

			// Token: 0x04000F55 RID: 3925
			private readonly int _sampleIntervalMsHigh;

			// Token: 0x04000F56 RID: 3926
			private readonly double _throughputErrorSmoothingFactor;

			// Token: 0x04000F57 RID: 3927
			private readonly double _gainExponent;

			// Token: 0x04000F58 RID: 3928
			private readonly double _maxSampleError;

			// Token: 0x04000F59 RID: 3929
			private double _currentControlSetting;

			// Token: 0x04000F5A RID: 3930
			private long _totalSamples;

			// Token: 0x04000F5B RID: 3931
			private int _lastThreadCount;

			// Token: 0x04000F5C RID: 3932
			private double _averageThroughputNoise;

			// Token: 0x04000F5D RID: 3933
			private double _secondsElapsedSinceLastChange;

			// Token: 0x04000F5E RID: 3934
			private double _completionsSinceLastChange;

			// Token: 0x04000F5F RID: 3935
			private int _accumulatedCompletionCount;

			// Token: 0x04000F60 RID: 3936
			private double _accumulatedSampleDurationSeconds;

			// Token: 0x04000F61 RID: 3937
			private readonly double[] _samples;

			// Token: 0x04000F62 RID: 3938
			private readonly double[] _threadCounts;

			// Token: 0x04000F63 RID: 3939
			private int _currentSampleMs;

			// Token: 0x04000F64 RID: 3940
			private readonly Random.XoshiroImpl _randomIntervalGenerator = new Random.XoshiroImpl();

			// Token: 0x04000F65 RID: 3941
			private readonly PortableThreadPool.HillClimbing.LogEntry[] _log = new PortableThreadPool.HillClimbing.LogEntry[200];

			// Token: 0x04000F66 RID: 3942
			private int _logStart;

			// Token: 0x04000F67 RID: 3943
			private int _logSize;

			// Token: 0x0200047A RID: 1146
			public enum StateOrTransition
			{
				// Token: 0x04000F69 RID: 3945
				Warmup,
				// Token: 0x04000F6A RID: 3946
				Initializing,
				// Token: 0x04000F6B RID: 3947
				RandomMove,
				// Token: 0x04000F6C RID: 3948
				ClimbingMove,
				// Token: 0x04000F6D RID: 3949
				ChangePoint,
				// Token: 0x04000F6E RID: 3950
				Stabilizing,
				// Token: 0x04000F6F RID: 3951
				Starvation,
				// Token: 0x04000F70 RID: 3952
				ThreadTimedOut,
				// Token: 0x04000F71 RID: 3953
				CooperativeBlocking
			}

			// Token: 0x0200047B RID: 1147
			private struct LogEntry
			{
				// Token: 0x04000F72 RID: 3954
				public int tickCount;

				// Token: 0x04000F73 RID: 3955
				public PortableThreadPool.HillClimbing.StateOrTransition stateOrTransition;

				// Token: 0x04000F74 RID: 3956
				public int newControlSetting;

				// Token: 0x04000F75 RID: 3957
				public int lastHistoryCount;

				// Token: 0x04000F76 RID: 3958
				public float lastHistoryMean;
			}

			// Token: 0x0200047C RID: 1148
			private readonly struct Complex
			{
				// Token: 0x060043F4 RID: 17396 RVA: 0x000E38C3 File Offset: 0x000E1AC3
				public Complex(double real, double imaginary)
				{
					this.Real = real;
					this.Imaginary = imaginary;
				}

				// Token: 0x17000C23 RID: 3107
				// (get) Token: 0x060043F5 RID: 17397 RVA: 0x000E38D3 File Offset: 0x000E1AD3
				public double Imaginary { get; }

				// Token: 0x17000C24 RID: 3108
				// (get) Token: 0x060043F6 RID: 17398 RVA: 0x000E38DB File Offset: 0x000E1ADB
				public double Real { get; }

				// Token: 0x060043F7 RID: 17399 RVA: 0x000E38E3 File Offset: 0x000E1AE3
				public static PortableThreadPool.HillClimbing.Complex operator *(double scalar, PortableThreadPool.HillClimbing.Complex complex)
				{
					return new PortableThreadPool.HillClimbing.Complex(scalar * complex.Real, scalar * complex.Imaginary);
				}

				// Token: 0x060043F8 RID: 17400 RVA: 0x000E38FC File Offset: 0x000E1AFC
				public static PortableThreadPool.HillClimbing.Complex operator /(PortableThreadPool.HillClimbing.Complex complex, double scalar)
				{
					return new PortableThreadPool.HillClimbing.Complex(complex.Real / scalar, complex.Imaginary / scalar);
				}

				// Token: 0x060043F9 RID: 17401 RVA: 0x000E3915 File Offset: 0x000E1B15
				public static PortableThreadPool.HillClimbing.Complex operator -(PortableThreadPool.HillClimbing.Complex lhs, PortableThreadPool.HillClimbing.Complex rhs)
				{
					return new PortableThreadPool.HillClimbing.Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
				}

				// Token: 0x060043FA RID: 17402 RVA: 0x000E393C File Offset: 0x000E1B3C
				public static PortableThreadPool.HillClimbing.Complex operator /(PortableThreadPool.HillClimbing.Complex lhs, PortableThreadPool.HillClimbing.Complex rhs)
				{
					double num = rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary;
					return new PortableThreadPool.HillClimbing.Complex((lhs.Real * rhs.Real + lhs.Imaginary * rhs.Imaginary) / num, (-lhs.Real * rhs.Imaginary + lhs.Imaginary * rhs.Real) / num);
				}

				// Token: 0x060043FB RID: 17403 RVA: 0x000E39B1 File Offset: 0x000E1BB1
				public double Abs()
				{
					return Math.Sqrt(this.Real * this.Real + this.Imaginary * this.Imaginary);
				}
			}
		}

		// Token: 0x0200047D RID: 1149
		private sealed class IOCompletionPoller
		{
			// Token: 0x060043FC RID: 17404 RVA: 0x000E39D4 File Offset: 0x000E1BD4
			public unsafe IOCompletionPoller(IntPtr port)
			{
				this._port = port;
				if (!PortableThreadPool.UnsafeInlineIOCompletionCallbacks)
				{
					this._nativeEvents = (Interop.Kernel32.OVERLAPPED_ENTRY*)NativeMemory.Alloc((UIntPtr)((IntPtr)1024), (UIntPtr)((IntPtr)sizeof(Interop.Kernel32.OVERLAPPED_ENTRY)));
					this._events = new ThreadPoolTypedWorkItemQueue<PortableThreadPool.IOCompletionPoller.Event, PortableThreadPool.IOCompletionPoller.Callback>();
					this._thread = new Thread(new ThreadStart(this.Poll), 262144);
					if (PortableThreadPool.IOCompletionPollerCount * 4 < Environment.ProcessorCount)
					{
						this._thread.Priority = ThreadPriority.AboveNormal;
					}
				}
				else
				{
					this._thread = new Thread(new ThreadStart(this.PollAndInlineCallbacks));
				}
				this._thread.IsThreadPoolThread = true;
				this._thread.IsBackground = true;
				this._thread.Name = ".NET ThreadPool IO";
				this._thread.UnsafeStart();
			}

			// Token: 0x060043FD RID: 17405 RVA: 0x000E3A9C File Offset: 0x000E1C9C
			private unsafe void Poll()
			{
				int num;
				while (Interop.Kernel32.GetQueuedCompletionStatusEx(this._port, this._nativeEvents, 1024, out num, -1, false))
				{
					for (int i = 0; i < num; i++)
					{
						Interop.Kernel32.OVERLAPPED_ENTRY* ptr = this._nativeEvents + i;
						if (ptr->lpOverlapped != null)
						{
							this._events.BatchEnqueue(new PortableThreadPool.IOCompletionPoller.Event(ptr->lpOverlapped, ptr->dwNumberOfBytesTransferred));
						}
					}
					this._events.CompleteBatchEnqueue();
				}
				ThrowHelper.ThrowApplicationException(Marshal.GetHRForLastWin32Error());
			}

			// Token: 0x060043FE RID: 17406 RVA: 0x000E3B20 File Offset: 0x000E1D20
			private unsafe void PollAndInlineCallbacks()
			{
				for (;;)
				{
					uint errorCode = 0U;
					uint numBytes;
					UIntPtr uintPtr;
					IntPtr intPtr;
					if (!Interop.Kernel32.GetQueuedCompletionStatus(this._port, out numBytes, out uintPtr, out intPtr, -1))
					{
						errorCode = (uint)Marshal.GetLastPInvokeError();
					}
					NativeOverlapped* ptr = intPtr;
					if (ptr != null)
					{
						if (NativeRuntimeEventSource.Log.IsEnabled())
						{
							NativeRuntimeEventSource.Log.ThreadPoolIODequeue(ptr);
						}
						IOCompletionCallbackHelper.PerformSingleIOCompletionCallback(errorCode, numBytes, ptr);
					}
				}
			}

			// Token: 0x04000F79 RID: 3961
			private readonly IntPtr _port;

			// Token: 0x04000F7A RID: 3962
			private unsafe readonly Interop.Kernel32.OVERLAPPED_ENTRY* _nativeEvents;

			// Token: 0x04000F7B RID: 3963
			private readonly ThreadPoolTypedWorkItemQueue<PortableThreadPool.IOCompletionPoller.Event, PortableThreadPool.IOCompletionPoller.Callback> _events;

			// Token: 0x04000F7C RID: 3964
			private readonly Thread _thread;

			// Token: 0x0200047E RID: 1150
			private struct Callback : IThreadPoolTypedWorkItemQueueCallback<PortableThreadPool.IOCompletionPoller.Event>
			{
				// Token: 0x060043FF RID: 17407 RVA: 0x000E3B70 File Offset: 0x000E1D70
				public unsafe static void Invoke(PortableThreadPool.IOCompletionPoller.Event e)
				{
					if (NativeRuntimeEventSource.Log.IsEnabled())
					{
						NativeRuntimeEventSource.Log.ThreadPoolIODequeue(e.nativeOverlapped);
					}
					uint num = (uint)e.nativeOverlapped->InternalLow;
					uint errorCode = 0U;
					if (!Interop.StatusOptions.NT_SUCCESS(num))
					{
						errorCode = Interop.NtDll.RtlNtStatusToDosError((int)num);
					}
					IOCompletionCallbackHelper.PerformSingleIOCompletionCallback(errorCode, e.bytesTransferred, e.nativeOverlapped);
				}
			}

			// Token: 0x0200047F RID: 1151
			private readonly struct Event
			{
				// Token: 0x06004400 RID: 17408 RVA: 0x000E3BC9 File Offset: 0x000E1DC9
				public unsafe Event(NativeOverlapped* nativeOverlapped, uint bytesTransferred)
				{
					this.nativeOverlapped = nativeOverlapped;
					this.bytesTransferred = bytesTransferred;
				}

				// Token: 0x04000F7D RID: 3965
				public unsafe readonly NativeOverlapped* nativeOverlapped;

				// Token: 0x04000F7E RID: 3966
				public readonly uint bytesTransferred;
			}
		}

		// Token: 0x02000480 RID: 1152
		private struct ThreadCounts : IEquatable<PortableThreadPool.ThreadCounts>
		{
			// Token: 0x06004401 RID: 17409 RVA: 0x000E3BD9 File Offset: 0x000E1DD9
			private ThreadCounts(ulong data)
			{
				this._data = data;
			}

			// Token: 0x06004402 RID: 17410 RVA: 0x000E3BE2 File Offset: 0x000E1DE2
			private short GetInt16Value(byte shift)
			{
				return (short)(this._data >> (int)shift);
			}

			// Token: 0x06004403 RID: 17411 RVA: 0x000E3BF0 File Offset: 0x000E1DF0
			private void SetInt16Value(short value, byte shift)
			{
				this._data = ((this._data & ~(65535UL << (int)shift)) | (ulong)((ushort)value) << (int)shift);
			}

			// Token: 0x17000C25 RID: 3109
			// (get) Token: 0x06004404 RID: 17412 RVA: 0x000E3C14 File Offset: 0x000E1E14
			// (set) Token: 0x06004405 RID: 17413 RVA: 0x000E3C1D File Offset: 0x000E1E1D
			public short NumProcessingWork
			{
				get
				{
					return this.GetInt16Value(0);
				}
				set
				{
					this.SetInt16Value(Math.Max(0, value), 0);
				}
			}

			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x06004406 RID: 17414 RVA: 0x000E3C2D File Offset: 0x000E1E2D
			// (set) Token: 0x06004407 RID: 17415 RVA: 0x000E3C37 File Offset: 0x000E1E37
			public short NumExistingThreads
			{
				get
				{
					return this.GetInt16Value(16);
				}
				set
				{
					this.SetInt16Value(Math.Max(0, value), 16);
				}
			}

			// Token: 0x17000C27 RID: 3111
			// (get) Token: 0x06004408 RID: 17416 RVA: 0x000E3C48 File Offset: 0x000E1E48
			// (set) Token: 0x06004409 RID: 17417 RVA: 0x000E3C52 File Offset: 0x000E1E52
			public short NumThreadsGoal
			{
				get
				{
					return this.GetInt16Value(32);
				}
				set
				{
					this.SetInt16Value(Math.Max(1, value), 32);
				}
			}

			// Token: 0x0600440A RID: 17418 RVA: 0x000E3C64 File Offset: 0x000E1E64
			public PortableThreadPool.ThreadCounts InterlockedSetNumThreadsGoal(short value)
			{
				PortableThreadPool.ThreadCounts threadCounts = this;
				PortableThreadPool.ThreadCounts threadCounts2;
				for (;;)
				{
					threadCounts2 = threadCounts;
					threadCounts2.NumThreadsGoal = value;
					PortableThreadPool.ThreadCounts threadCounts3 = this.InterlockedCompareExchange(threadCounts2, threadCounts);
					if (threadCounts3 == threadCounts)
					{
						break;
					}
					threadCounts = threadCounts3;
				}
				return threadCounts2;
			}

			// Token: 0x0600440B RID: 17419 RVA: 0x000E3C99 File Offset: 0x000E1E99
			public PortableThreadPool.ThreadCounts VolatileRead()
			{
				return new PortableThreadPool.ThreadCounts(Volatile.Read(ref this._data));
			}

			// Token: 0x0600440C RID: 17420 RVA: 0x000E3CAB File Offset: 0x000E1EAB
			public PortableThreadPool.ThreadCounts InterlockedCompareExchange(PortableThreadPool.ThreadCounts newCounts, PortableThreadPool.ThreadCounts oldCounts)
			{
				return new PortableThreadPool.ThreadCounts(Interlocked.CompareExchange(ref this._data, newCounts._data, oldCounts._data));
			}

			// Token: 0x0600440D RID: 17421 RVA: 0x000E3CC9 File Offset: 0x000E1EC9
			public static bool operator ==(PortableThreadPool.ThreadCounts lhs, PortableThreadPool.ThreadCounts rhs)
			{
				return lhs._data == rhs._data;
			}

			// Token: 0x0600440E RID: 17422 RVA: 0x000E3CDC File Offset: 0x000E1EDC
			public override bool Equals([NotNullWhen(true)] object obj)
			{
				if (obj is PortableThreadPool.ThreadCounts)
				{
					PortableThreadPool.ThreadCounts other = (PortableThreadPool.ThreadCounts)obj;
					return this.Equals(other);
				}
				return false;
			}

			// Token: 0x0600440F RID: 17423 RVA: 0x000E3CC9 File Offset: 0x000E1EC9
			public bool Equals(PortableThreadPool.ThreadCounts other)
			{
				return this._data == other._data;
			}

			// Token: 0x06004410 RID: 17424 RVA: 0x000E3D01 File Offset: 0x000E1F01
			public override int GetHashCode()
			{
				return (int)this._data + (int)(this._data >> 32);
			}

			// Token: 0x04000F7F RID: 3967
			private ulong _data;
		}

		// Token: 0x02000481 RID: 1153
		private sealed class WaitThreadNode
		{
			// Token: 0x17000C28 RID: 3112
			// (get) Token: 0x06004411 RID: 17425 RVA: 0x000E3D15 File Offset: 0x000E1F15
			public PortableThreadPool.WaitThread Thread { get; }

			// Token: 0x17000C29 RID: 3113
			// (get) Token: 0x06004412 RID: 17426 RVA: 0x000E3D1D File Offset: 0x000E1F1D
			// (set) Token: 0x06004413 RID: 17427 RVA: 0x000E3D25 File Offset: 0x000E1F25
			public PortableThreadPool.WaitThreadNode Next { get; set; }

			// Token: 0x06004414 RID: 17428 RVA: 0x000E3D2E File Offset: 0x000E1F2E
			public WaitThreadNode(PortableThreadPool.WaitThread thread)
			{
				this.Thread = thread;
			}
		}

		// Token: 0x02000482 RID: 1154
		internal sealed class WaitThread
		{
			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x06004415 RID: 17429 RVA: 0x000E3D3D File Offset: 0x000E1F3D
			internal bool AnyUserWaits
			{
				get
				{
					return this._numUserWaits != 0;
				}
			}

			// Token: 0x06004416 RID: 17430 RVA: 0x000E3D48 File Offset: 0x000E1F48
			public WaitThread()
			{
				this._waitHandles[0] = this._changeHandlesEvent.SafeWaitHandle;
				new Thread(new ThreadStart(this.WaitThreadStart), 262144)
				{
					IsThreadPoolThread = true,
					IsBackground = true,
					Name = ".NET TP Wait"
				}.UnsafeStart();
			}

			// Token: 0x06004417 RID: 17431 RVA: 0x000E3DD8 File Offset: 0x000E1FD8
			private void WaitThreadStart()
			{
				for (;;)
				{
					int num = this.ProcessRemovals();
					int tickCount = Environment.TickCount;
					int num2 = -1;
					if (num == 0)
					{
						num2 = PortableThreadPool.ThreadPoolThreadTimeoutMs;
					}
					else
					{
						for (int i = 0; i < num; i++)
						{
							RegisteredWaitHandle registeredWaitHandle = this._registeredWaits[i];
							if (!registeredWaitHandle.IsInfiniteTimeout)
							{
								int num3 = Math.Max(0, registeredWaitHandle.TimeoutTimeMs - tickCount);
								if (num2 == -1)
								{
									num2 = num3;
								}
								else
								{
									num2 = Math.Min(num3, num2);
								}
								if (num2 == 0)
								{
									break;
								}
							}
						}
					}
					int num4 = WaitHandle.WaitAny(new ReadOnlySpan<SafeWaitHandle>(this._waitHandles, 0, num + 1), num2);
					if (num4 >= 128 && num4 < 129 + num)
					{
						num4 += -128;
					}
					if (num4 != 0)
					{
						if (num4 != 258)
						{
							RegisteredWaitHandle registeredHandle = this._registeredWaits[num4 - 1];
							this.QueueWaitCompletion(registeredHandle, false);
						}
						else
						{
							if (num == 0 && PortableThreadPool.ThreadPoolInstance.TryRemoveWaitThread(this))
							{
								break;
							}
							tickCount = Environment.TickCount;
							for (int j = 0; j < num; j++)
							{
								RegisteredWaitHandle registeredWaitHandle2 = this._registeredWaits[j];
								if (!registeredWaitHandle2.IsInfiniteTimeout && tickCount - registeredWaitHandle2.TimeoutTimeMs >= 0)
								{
									this.QueueWaitCompletion(registeredWaitHandle2, true);
								}
							}
						}
					}
				}
			}

			// Token: 0x06004418 RID: 17432 RVA: 0x000E3EF4 File Offset: 0x000E20F4
			private int ProcessRemovals()
			{
				PortableThreadPool threadPoolInstance = PortableThreadPool.ThreadPoolInstance;
				threadPoolInstance._waitThreadLock.Acquire();
				int numUserWaits;
				try
				{
					if (this._numPendingRemoves == 0 || this._numUserWaits == 0)
					{
						numUserWaits = this._numUserWaits;
					}
					else
					{
						int numUserWaits2 = this._numUserWaits;
						int numPendingRemoves = this._numPendingRemoves;
						for (int i = 0; i < this._numPendingRemoves; i++)
						{
							RegisteredWaitHandle registeredWaitHandle = this._pendingRemoves[i];
							int numUserWaits3 = this._numUserWaits;
							int num = 0;
							while (num < numUserWaits3 && registeredWaitHandle != this._registeredWaits[num])
							{
								num++;
							}
							registeredWaitHandle.OnRemoveWait();
							if (num + 1 < numUserWaits3)
							{
								int num2 = num;
								int num3 = numUserWaits3;
								Array.Copy(this._registeredWaits, num2 + 1, this._registeredWaits, num2, num3 - (num2 + 1));
								this._registeredWaits[num3 - 1] = null;
								num2++;
								num3++;
								Array.Copy(this._waitHandles, num2 + 1, this._waitHandles, num2, num3 - (num2 + 1));
								this._waitHandles[num3 - 1] = null;
							}
							else
							{
								this._registeredWaits[num] = null;
								this._waitHandles[num + 1] = null;
							}
							this._numUserWaits = numUserWaits3 - 1;
							this._pendingRemoves[i] = null;
							registeredWaitHandle.Handle.DangerousRelease();
						}
						this._numPendingRemoves = 0;
						numUserWaits = this._numUserWaits;
					}
				}
				finally
				{
					threadPoolInstance._waitThreadLock.Release();
				}
				return numUserWaits;
			}

			// Token: 0x06004419 RID: 17433 RVA: 0x000E4068 File Offset: 0x000E2268
			private void QueueWaitCompletion(RegisteredWaitHandle registeredHandle, bool timedOut)
			{
				registeredHandle.RequestCallback();
				if (registeredHandle.Repeating)
				{
					if (!registeredHandle.IsInfiniteTimeout)
					{
						registeredHandle.RestartTimeout();
					}
				}
				else
				{
					this.UnregisterWait(registeredHandle, false);
				}
				ThreadPool.UnsafeQueueHighPriorityWorkItemInternal(new CompleteWaitThreadPoolWorkItem(registeredHandle, timedOut));
			}

			// Token: 0x0600441A RID: 17434 RVA: 0x000E409C File Offset: 0x000E229C
			public bool RegisterWaitHandle(RegisteredWaitHandle handle)
			{
				if (this._numUserWaits == 63)
				{
					return false;
				}
				bool flag = false;
				handle.Handle.DangerousAddRef(ref flag);
				this._registeredWaits[this._numUserWaits] = handle;
				this._waitHandles[this._numUserWaits + 1] = handle.Handle;
				this._numUserWaits++;
				handle.WaitThread = this;
				this._changeHandlesEvent.Set();
				return true;
			}

			// Token: 0x0600441B RID: 17435 RVA: 0x000E4109 File Offset: 0x000E2309
			public void UnregisterWait(RegisteredWaitHandle handle)
			{
				this.UnregisterWait(handle, true);
			}

			// Token: 0x0600441C RID: 17436 RVA: 0x000E4114 File Offset: 0x000E2314
			private void UnregisterWait(RegisteredWaitHandle handle, bool blocking)
			{
				bool flag = false;
				PortableThreadPool threadPoolInstance = PortableThreadPool.ThreadPoolInstance;
				threadPoolInstance._waitThreadLock.Acquire();
				try
				{
					if (Array.IndexOf<RegisteredWaitHandle>(this._registeredWaits, handle) >= 0)
					{
						if (Array.IndexOf<RegisteredWaitHandle>(this._pendingRemoves, handle) < 0)
						{
							RegisteredWaitHandle[] pendingRemoves = this._pendingRemoves;
							int numPendingRemoves = this._numPendingRemoves;
							this._numPendingRemoves = numPendingRemoves + 1;
							pendingRemoves[numPendingRemoves] = handle;
							this._changeHandlesEvent.Set();
						}
						flag = true;
					}
				}
				finally
				{
					threadPoolInstance._waitThreadLock.Release();
				}
				if (blocking)
				{
					if (handle.IsBlocking)
					{
						handle.WaitForCallbacks();
						return;
					}
					if (flag)
					{
						handle.WaitForRemoval();
					}
				}
			}

			// Token: 0x04000F82 RID: 3970
			private readonly RegisteredWaitHandle[] _registeredWaits = new RegisteredWaitHandle[63];

			// Token: 0x04000F83 RID: 3971
			private readonly SafeWaitHandle[] _waitHandles = new SafeWaitHandle[64];

			// Token: 0x04000F84 RID: 3972
			private int _numUserWaits;

			// Token: 0x04000F85 RID: 3973
			private readonly RegisteredWaitHandle[] _pendingRemoves = new RegisteredWaitHandle[63];

			// Token: 0x04000F86 RID: 3974
			private int _numPendingRemoves;

			// Token: 0x04000F87 RID: 3975
			private readonly AutoResetEvent _changeHandlesEvent = new AutoResetEvent(false);
		}

		// Token: 0x02000483 RID: 1155
		private static class WorkerThread
		{
			// Token: 0x0600441D RID: 17437 RVA: 0x000E41B4 File Offset: 0x000E23B4
			private static short DetermineThreadsToKeepAlive()
			{
				short int16Config = AppContextConfigHelper.GetInt16Config("System.Threading.ThreadPool.ThreadsToKeepAlive", "DOTNET_ThreadPool_ThreadsToKeepAlive", 0, true);
				if (int16Config < -1)
				{
					return 0;
				}
				return int16Config;
			}

			// Token: 0x0600441E RID: 17438 RVA: 0x000E41DA File Offset: 0x000E23DA
			private static void CreateWorkerThread()
			{
				new Thread(PortableThreadPool.WorkerThread.s_workerThreadStart)
				{
					IsThreadPoolThread = true,
					IsBackground = true
				}.UnsafeStart();
			}

			// Token: 0x0600441F RID: 17439 RVA: 0x000E41FC File Offset: 0x000E23FC
			private static void WorkerThreadStart()
			{
				Thread.CurrentThread.SetThreadPoolWorkerThreadName();
				PortableThreadPool threadPoolInstance = PortableThreadPool.ThreadPoolInstance;
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolWorkerThreadStart((uint)threadPoolInstance._separated.counts.VolatileRead().NumExistingThreads, 0U, 0);
				}
				LowLevelLock threadAdjustmentLock = threadPoolInstance._threadAdjustmentLock;
				LowLevelLifoSemaphore lowLevelLifoSemaphore = PortableThreadPool.WorkerThread.s_semaphore;
				int timeoutMs = PortableThreadPool.ThreadPoolThreadTimeoutMs;
				if (PortableThreadPool.WorkerThread.ThreadsToKeepAlive != 0)
				{
					if (PortableThreadPool.WorkerThread.ThreadsToKeepAlive < 0)
					{
						timeoutMs = -1;
					}
					else
					{
						int num;
						for (int i = threadPoolInstance._numThreadsBeingKeptAlive; i < (int)PortableThreadPool.WorkerThread.ThreadsToKeepAlive; i = num)
						{
							num = Interlocked.CompareExchange(ref threadPoolInstance._numThreadsBeingKeptAlive, i + 1, i);
							if (num == i)
							{
								timeoutMs = -1;
								break;
							}
						}
					}
				}
				do
				{
					bool spinWait = true;
					while (lowLevelLifoSemaphore.Wait(timeoutMs, spinWait))
					{
						PortableThreadPool.WorkerThread.WorkerDoWork(threadPoolInstance, ref spinWait);
					}
				}
				while (!PortableThreadPool.WorkerThread.ShouldExitWorker(threadPoolInstance, threadAdjustmentLock));
			}

			// Token: 0x06004420 RID: 17440 RVA: 0x000E42C8 File Offset: 0x000E24C8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static void WorkerDoWork(PortableThreadPool threadPoolInstance, ref bool spinWait)
			{
				bool flag = false;
				while (PortableThreadPool.WorkerThread.TakeActiveRequest(threadPoolInstance))
				{
					threadPoolInstance._separated.lastDequeueTime = Environment.TickCount;
					if (!ThreadPoolWorkQueue.Dispatch())
					{
						flag = true;
						break;
					}
					if (threadPoolInstance._separated.numRequestedWorkers <= 0)
					{
						break;
					}
					Thread.UninterruptibleSleep0();
					if (!Environment.IsSingleProcessor)
					{
						Thread.SpinWait(1);
					}
				}
				spinWait = !flag;
				if (!flag)
				{
					PortableThreadPool.WorkerThread.RemoveWorkingWorker(threadPoolInstance);
				}
			}

			// Token: 0x06004421 RID: 17441 RVA: 0x000E4330 File Offset: 0x000E2530
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static bool ShouldExitWorker(PortableThreadPool threadPoolInstance, LowLevelLock threadAdjustmentLock)
			{
				if (PortableThreadPool.WorkerThread.IsIOPending)
				{
					return false;
				}
				threadAdjustmentLock.Acquire();
				bool result;
				try
				{
					PortableThreadPool.ThreadCounts threadCounts = threadPoolInstance._separated.counts;
					while (threadCounts.NumExistingThreads > threadCounts.NumProcessingWork)
					{
						PortableThreadPool.ThreadCounts newCounts = threadCounts;
						short num = newCounts.NumExistingThreads - 1;
						newCounts.NumExistingThreads = num;
						short num2 = num;
						short num3 = Math.Max(threadPoolInstance.MinThreadsGoal, Math.Min(num2, threadCounts.NumThreadsGoal));
						newCounts.NumThreadsGoal = num3;
						PortableThreadPool.ThreadCounts threadCounts2 = threadPoolInstance._separated.counts.InterlockedCompareExchange(newCounts, threadCounts);
						if (threadCounts2 == threadCounts)
						{
							PortableThreadPool.HillClimbing.ThreadPoolHillClimber.ForceChange((int)num3, PortableThreadPool.HillClimbing.StateOrTransition.ThreadTimedOut);
							if (NativeRuntimeEventSource.Log.IsEnabled())
							{
								NativeRuntimeEventSource.Log.ThreadPoolWorkerThreadStop((uint)num2, 0U, 0);
							}
							return true;
						}
						threadCounts = threadCounts2;
					}
					result = false;
				}
				finally
				{
					threadAdjustmentLock.Release();
				}
				return result;
			}

			// Token: 0x06004422 RID: 17442 RVA: 0x000E4414 File Offset: 0x000E2614
			private static void RemoveWorkingWorker(PortableThreadPool threadPoolInstance)
			{
				PortableThreadPool.ThreadCounts threadCounts = threadPoolInstance._separated.counts;
				for (;;)
				{
					PortableThreadPool.ThreadCounts newCounts = threadCounts;
					short numProcessingWork = newCounts.NumProcessingWork;
					newCounts.NumProcessingWork = numProcessingWork - 1;
					PortableThreadPool.ThreadCounts threadCounts2 = threadPoolInstance._separated.counts.InterlockedCompareExchange(newCounts, threadCounts);
					if (threadCounts2 == threadCounts)
					{
						break;
					}
					threadCounts = threadCounts2;
				}
				if (threadPoolInstance._separated.numRequestedWorkers > 0)
				{
					PortableThreadPool.WorkerThread.MaybeAddWorkingWorker(threadPoolInstance);
				}
			}

			// Token: 0x06004423 RID: 17443 RVA: 0x000E4478 File Offset: 0x000E2678
			internal static void MaybeAddWorkingWorker(PortableThreadPool threadPoolInstance)
			{
				PortableThreadPool.ThreadCounts threadCounts = threadPoolInstance._separated.counts;
				short numProcessingWork;
				short num;
				short numExistingThreads;
				short num2;
				for (;;)
				{
					numProcessingWork = threadCounts.NumProcessingWork;
					if (numProcessingWork >= threadCounts.NumThreadsGoal)
					{
						break;
					}
					num = numProcessingWork + 1;
					numExistingThreads = threadCounts.NumExistingThreads;
					num2 = Math.Max(numExistingThreads, num);
					PortableThreadPool.ThreadCounts newCounts = threadCounts;
					newCounts.NumProcessingWork = num;
					newCounts.NumExistingThreads = num2;
					PortableThreadPool.ThreadCounts threadCounts2 = threadPoolInstance._separated.counts.InterlockedCompareExchange(newCounts, threadCounts);
					if (threadCounts2 == threadCounts)
					{
						goto IL_6E;
					}
					threadCounts = threadCounts2;
				}
				return;
				IL_6E:
				int i = (int)(num2 - numExistingThreads);
				int num3 = (int)(num - numProcessingWork);
				if (num3 > 0)
				{
					PortableThreadPool.WorkerThread.s_semaphore.Release(num3);
				}
				while (i > 0)
				{
					PortableThreadPool.WorkerThread.CreateWorkerThread();
					i--;
				}
			}

			// Token: 0x06004424 RID: 17444 RVA: 0x000E4524 File Offset: 0x000E2724
			internal static bool ShouldStopProcessingWorkNow(PortableThreadPool threadPoolInstance)
			{
				PortableThreadPool.ThreadCounts threadCounts = threadPoolInstance._separated.counts;
				while (threadCounts.NumProcessingWork > threadCounts.NumThreadsGoal)
				{
					PortableThreadPool.ThreadCounts newCounts = threadCounts;
					short numProcessingWork = newCounts.NumProcessingWork;
					newCounts.NumProcessingWork = numProcessingWork - 1;
					PortableThreadPool.ThreadCounts threadCounts2 = threadPoolInstance._separated.counts.InterlockedCompareExchange(newCounts, threadCounts);
					if (threadCounts2 == threadCounts)
					{
						return true;
					}
					threadCounts = threadCounts2;
				}
				return false;
			}

			// Token: 0x06004425 RID: 17445 RVA: 0x000E4584 File Offset: 0x000E2784
			private static bool TakeActiveRequest(PortableThreadPool threadPoolInstance)
			{
				int num;
				for (int i = threadPoolInstance._separated.numRequestedWorkers; i > 0; i = num)
				{
					num = Interlocked.CompareExchange(ref threadPoolInstance._separated.numRequestedWorkers, i - 1, i);
					if (num == i)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x06004426 RID: 17446 RVA: 0x000E45C4 File Offset: 0x000E27C4
			private static bool IsIOPending
			{
				get
				{
					Interop.BOOL @bool;
					return !Interop.Kernel32.GetThreadIOPendingFlag(Interop.Kernel32.GetCurrentThread(), out @bool) || @bool > Interop.BOOL.FALSE;
				}
			}

			// Token: 0x04000F88 RID: 3976
			private static readonly short ThreadsToKeepAlive = PortableThreadPool.WorkerThread.DetermineThreadsToKeepAlive();

			// Token: 0x04000F89 RID: 3977
			private static readonly LowLevelLifoSemaphore s_semaphore = new LowLevelLifoSemaphore(0, 32767, AppContextConfigHelper.GetInt32Config("System.Threading.ThreadPool.UnfairSemaphoreSpinLimit", 70, false), delegate()
			{
				if (NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ThreadPoolWorkerThreadWait((uint)PortableThreadPool.ThreadPoolInstance._separated.counts.VolatileRead().NumExistingThreads, 0U, 0);
				}
			});

			// Token: 0x04000F8A RID: 3978
			private static readonly ThreadStart s_workerThreadStart = new ThreadStart(PortableThreadPool.WorkerThread.WorkerThreadStart);
		}

		// Token: 0x02000485 RID: 1157
		private struct CountsOfThreadsProcessingUserCallbacks : IEquatable<PortableThreadPool.CountsOfThreadsProcessingUserCallbacks>
		{
			// Token: 0x0600442B RID: 17451 RVA: 0x000E468D File Offset: 0x000E288D
			private CountsOfThreadsProcessingUserCallbacks(uint data)
			{
				this._data = data;
			}

			// Token: 0x0600442C RID: 17452 RVA: 0x000E4696 File Offset: 0x000E2896
			private short GetInt16Value(byte shift)
			{
				return (short)(this._data >> (int)shift);
			}

			// Token: 0x0600442D RID: 17453 RVA: 0x000E46A4 File Offset: 0x000E28A4
			private void SetInt16Value(short value, byte shift)
			{
				this._data = ((this._data & ~(65535U << (int)shift)) | (uint)((uint)((ushort)value) << (int)shift));
			}

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x0600442E RID: 17454 RVA: 0x000E46C6 File Offset: 0x000E28C6
			public short Current
			{
				get
				{
					return this.GetInt16Value(0);
				}
			}

			// Token: 0x0600442F RID: 17455 RVA: 0x000E46CF File Offset: 0x000E28CF
			public void IncrementCurrent()
			{
				if (this.Current < this.HighWatermark)
				{
					this._data += 1U;
					return;
				}
				this._data += 65537U;
			}

			// Token: 0x06004430 RID: 17456 RVA: 0x000E4700 File Offset: 0x000E2900
			public void DecrementCurrent()
			{
				this._data -= 1U;
			}

			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x06004431 RID: 17457 RVA: 0x000E4710 File Offset: 0x000E2910
			public short HighWatermark
			{
				get
				{
					return this.GetInt16Value(16);
				}
			}

			// Token: 0x06004432 RID: 17458 RVA: 0x000E471A File Offset: 0x000E291A
			public void ResetHighWatermark()
			{
				this.SetInt16Value(this.Current, 16);
			}

			// Token: 0x06004433 RID: 17459 RVA: 0x000E472A File Offset: 0x000E292A
			public PortableThreadPool.CountsOfThreadsProcessingUserCallbacks InterlockedCompareExchange(PortableThreadPool.CountsOfThreadsProcessingUserCallbacks newCounts, PortableThreadPool.CountsOfThreadsProcessingUserCallbacks oldCounts)
			{
				return new PortableThreadPool.CountsOfThreadsProcessingUserCallbacks(Interlocked.CompareExchange(ref this._data, newCounts._data, oldCounts._data));
			}

			// Token: 0x06004434 RID: 17460 RVA: 0x000E4748 File Offset: 0x000E2948
			public static bool operator ==(PortableThreadPool.CountsOfThreadsProcessingUserCallbacks lhs, PortableThreadPool.CountsOfThreadsProcessingUserCallbacks rhs)
			{
				return lhs.Equals(rhs);
			}

			// Token: 0x06004435 RID: 17461 RVA: 0x000E4754 File Offset: 0x000E2954
			public override bool Equals([NotNullWhen(true)] object obj)
			{
				if (obj is PortableThreadPool.CountsOfThreadsProcessingUserCallbacks)
				{
					PortableThreadPool.CountsOfThreadsProcessingUserCallbacks other = (PortableThreadPool.CountsOfThreadsProcessingUserCallbacks)obj;
					return this.Equals(other);
				}
				return false;
			}

			// Token: 0x06004436 RID: 17462 RVA: 0x000E4779 File Offset: 0x000E2979
			public bool Equals(PortableThreadPool.CountsOfThreadsProcessingUserCallbacks other)
			{
				return this._data == other._data;
			}

			// Token: 0x06004437 RID: 17463 RVA: 0x000E4789 File Offset: 0x000E2989
			public override int GetHashCode()
			{
				return (int)this._data;
			}

			// Token: 0x04000F8C RID: 3980
			private uint _data;
		}

		// Token: 0x02000486 RID: 1158
		private struct CpuUtilizationReader
		{
			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x06004438 RID: 17464 RVA: 0x000E4794 File Offset: 0x000E2994
			public int CurrentUtilization
			{
				get
				{
					long num;
					long num2;
					long num3;
					if (!Interop.Kernel32.GetSystemTimes(out num, out num2, out num3))
					{
						return 0;
					}
					long num4 = num3 - this._userTime + (num2 - this._kernelTime);
					long num5 = num4 - (num - this._idleTime);
					this._kernelTime = num2;
					this._userTime = num3;
					this._idleTime = num;
					if (num4 > 0L && num5 > 0L)
					{
						return (int)Math.Min(num5 * 100L / num4, 100L);
					}
					return 0;
				}
			}

			// Token: 0x04000F8D RID: 3981
			public long _idleTime;

			// Token: 0x04000F8E RID: 3982
			public long _kernelTime;

			// Token: 0x04000F8F RID: 3983
			public long _userTime;
		}
	}
}
