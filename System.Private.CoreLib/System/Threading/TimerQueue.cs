using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x02000446 RID: 1094
	[DebuggerDisplay("Count = {CountForDebugger}")]
	[DebuggerTypeProxy(typeof(TimerQueue.TimerQueueDebuggerTypeProxy))]
	internal sealed class TimerQueue : IThreadPoolWorkItem
	{
		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06004282 RID: 17026 RVA: 0x000DDD12 File Offset: 0x000DBF12
		public static TimerQueue[] Instances { get; } = TimerQueue.CreateTimerQueues();

		// Token: 0x06004283 RID: 17027 RVA: 0x000DDD1C File Offset: 0x000DBF1C
		private static TimerQueue[] CreateTimerQueues()
		{
			TimerQueue[] array = new TimerQueue[Environment.ProcessorCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new TimerQueue(i);
			}
			return array;
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x000DDD4C File Offset: 0x000DBF4C
		private int CountForDebugger
		{
			get
			{
				int num = 0;
				foreach (TimerQueueTimer timerQueueTimer in this.GetTimersForDebugger())
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x000DDD9C File Offset: 0x000DBF9C
		internal IEnumerable<TimerQueueTimer> GetTimersForDebugger()
		{
			TimerQueueTimer timer;
			for (timer = this._shortTimers; timer != null; timer = timer._next)
			{
				yield return timer;
			}
			timer = null;
			for (timer = this._longTimers; timer != null; timer = timer._next)
			{
				yield return timer;
			}
			timer = null;
			yield break;
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x000DDDAC File Offset: 0x000DBFAC
		private bool EnsureTimerFiresBy(uint requestedDuration)
		{
			uint num = Math.Min(requestedDuration, 268435455U);
			if (this._isTimerScheduled)
			{
				long num2 = TimerQueue.TickCount64 - this._currentTimerStartTicks;
				if (num2 >= (long)((ulong)this._currentTimerDuration))
				{
					return true;
				}
				uint num3 = this._currentTimerDuration - (uint)num2;
				if (num >= num3)
				{
					return true;
				}
			}
			if (this.SetTimer(num))
			{
				this._isTimerScheduled = true;
				this._currentTimerStartTicks = TimerQueue.TickCount64;
				this._currentTimerDuration = num;
				return true;
			}
			return false;
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x000DDE1B File Offset: 0x000DC01B
		internal Lock SharedLock { get; } = new Lock();

		// Token: 0x06004288 RID: 17032 RVA: 0x000DDE24 File Offset: 0x000DC024
		private void FireNextTimers()
		{
			TimerQueueTimer timerQueueTimer = null;
			using (this.SharedLock.EnterScope())
			{
				this._isTimerScheduled = false;
				bool flag = false;
				uint num = uint.MaxValue;
				long tickCount = TimerQueue.TickCount64;
				TimerQueueTimer timerQueueTimer2 = this._shortTimers;
				for (int i = 0; i < 2; i++)
				{
					while (timerQueueTimer2 != null)
					{
						TimerQueueTimer next = timerQueueTimer2._next;
						long num2 = tickCount - timerQueueTimer2._startTicks;
						long num3 = (long)((ulong)timerQueueTimer2._dueTime - (ulong)num2);
						if (num3 <= 0L)
						{
							timerQueueTimer2._everQueued = true;
							if (timerQueueTimer2._period != 4294967295U)
							{
								timerQueueTimer2._startTicks = tickCount;
								long num4 = num2 - (long)((ulong)timerQueueTimer2._dueTime);
								timerQueueTimer2._dueTime = ((num4 < (long)((ulong)timerQueueTimer2._period)) ? (timerQueueTimer2._period - (uint)num4) : 1U);
								if (timerQueueTimer2._dueTime < num)
								{
									flag = true;
									num = timerQueueTimer2._dueTime;
								}
								bool flag2 = tickCount + (long)((ulong)timerQueueTimer2._dueTime) - this._currentAbsoluteThreshold <= 0L;
								if (timerQueueTimer2._short != flag2)
								{
									this.MoveTimerToCorrectList(timerQueueTimer2, flag2);
								}
							}
							else
							{
								this.DeleteTimer(timerQueueTimer2);
							}
							if (timerQueueTimer == null)
							{
								timerQueueTimer = timerQueueTimer2;
							}
							else
							{
								ThreadPool.UnsafeQueueUserWorkItemInternal(timerQueueTimer2, false);
							}
						}
						else
						{
							if (num3 < (long)((ulong)num))
							{
								flag = true;
								num = (uint)num3;
							}
							if (!timerQueueTimer2._short && num3 <= 333L)
							{
								this.MoveTimerToCorrectList(timerQueueTimer2, true);
							}
						}
						timerQueueTimer2 = next;
					}
					if (i == 0)
					{
						long num5 = this._currentAbsoluteThreshold - tickCount;
						if (num5 > 0L)
						{
							if (this._shortTimers == null && this._longTimers != null)
							{
								num = (uint)num5 + 1U;
								flag = true;
								break;
							}
							break;
						}
						else
						{
							timerQueueTimer2 = this._longTimers;
							this._currentAbsoluteThreshold = tickCount + 333L;
						}
					}
				}
				if (flag)
				{
					this.EnsureTimerFiresBy(num);
				}
			}
			if (timerQueueTimer != null)
			{
				timerQueueTimer.Fire(false);
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x000DDFF0 File Offset: 0x000DC1F0
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x000DDFF8 File Offset: 0x000DC1F8
		public long ActiveCount { get; private set; }

		// Token: 0x0600428B RID: 17035 RVA: 0x000DE004 File Offset: 0x000DC204
		public bool UpdateTimer(TimerQueueTimer timer, uint dueTime, uint period)
		{
			long tickCount = TimerQueue.TickCount64;
			long num = tickCount + (long)((ulong)dueTime);
			bool flag = this._currentAbsoluteThreshold - num >= 0L;
			if (timer._dueTime == 4294967295U)
			{
				timer._short = flag;
				this.LinkTimer(timer);
				long activeCount = this.ActiveCount + 1L;
				this.ActiveCount = activeCount;
			}
			else if (timer._short != flag)
			{
				this.UnlinkTimer(timer);
				timer._short = flag;
				this.LinkTimer(timer);
			}
			timer._dueTime = dueTime;
			timer._period = ((period == 0U) ? uint.MaxValue : period);
			timer._startTicks = tickCount;
			return this.EnsureTimerFiresBy(dueTime);
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x000DE096 File Offset: 0x000DC296
		public void MoveTimerToCorrectList(TimerQueueTimer timer, bool shortList)
		{
			this.UnlinkTimer(timer);
			timer._short = shortList;
			this.LinkTimer(timer);
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x000DE0B0 File Offset: 0x000DC2B0
		private void LinkTimer(TimerQueueTimer timer)
		{
			ref TimerQueueTimer ptr = ref timer._short ? ref this._shortTimers : ref this._longTimers;
			timer._next = ptr;
			if (timer._next != null)
			{
				timer._next._prev = timer;
			}
			timer._prev = null;
			ptr = timer;
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x000DE0FC File Offset: 0x000DC2FC
		private void UnlinkTimer(TimerQueueTimer timer)
		{
			TimerQueueTimer timerQueueTimer = timer._next;
			if (timerQueueTimer != null)
			{
				timerQueueTimer._prev = timer._prev;
			}
			if (this._shortTimers == timer)
			{
				this._shortTimers = timerQueueTimer;
			}
			else if (this._longTimers == timer)
			{
				this._longTimers = timerQueueTimer;
			}
			timerQueueTimer = timer._prev;
			if (timerQueueTimer != null)
			{
				timerQueueTimer._next = timer._next;
			}
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x000DE158 File Offset: 0x000DC358
		public void DeleteTimer(TimerQueueTimer timer)
		{
			if (timer._dueTime != 4294967295U)
			{
				long activeCount = this.ActiveCount - 1L;
				this.ActiveCount = activeCount;
				this.UnlinkTimer(timer);
				timer._prev = null;
				timer._next = null;
				timer._dueTime = uint.MaxValue;
				timer._period = uint.MaxValue;
				timer._startTicks = 0L;
				timer._short = false;
			}
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x000DE1B4 File Offset: 0x000DC3B4
		private static List<TimerQueue> InitializeScheduledTimerManager_Locked()
		{
			List<TimerQueue> result = new List<TimerQueue>(TimerQueue.Instances.Length);
			if (TimerQueue.s_scheduledTimersToFire == null)
			{
				TimerQueue.s_scheduledTimersToFire = new List<TimerQueue>(TimerQueue.Instances.Length);
			}
			ThreadStart start;
			if ((start = TimerQueue.<>O.<0>__TimerThread) == null)
			{
				start = (TimerQueue.<>O.<0>__TimerThread = new ThreadStart(TimerQueue.TimerThread));
			}
			new Thread(start)
			{
				Name = ".NET Timer",
				IsBackground = true
			}.UnsafeStart();
			TimerQueue.s_scheduledTimers = result;
			return result;
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x000DE224 File Offset: 0x000DC424
		private bool SetTimerPortable(uint actualDuration)
		{
			long scheduledDueTimeMs = TimerQueue.TickCount64 + (long)actualDuration;
			AutoResetEvent autoResetEvent = TimerQueue.s_timerEvent;
			using (TimerQueue.s_timerEventLock.EnterScope())
			{
				if (!this._isScheduled)
				{
					(TimerQueue.s_scheduledTimers ?? TimerQueue.InitializeScheduledTimerManager_Locked()).Add(this);
					this._isScheduled = true;
				}
				this._scheduledDueTimeMs = scheduledDueTimeMs;
			}
			autoResetEvent.Set();
			return true;
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x000DE298 File Offset: 0x000DC498
		private static void TimerThread()
		{
			AutoResetEvent autoResetEvent = TimerQueue.s_timerEvent;
			Lock @lock = TimerQueue.s_timerEventLock;
			List<TimerQueue> list = TimerQueue.s_scheduledTimersToFire;
			List<TimerQueue> list2;
			using (@lock.EnterScope())
			{
				list2 = TimerQueue.s_scheduledTimers;
			}
			int num = -1;
			for (;;)
			{
				autoResetEvent.WaitOne(num);
				long tickCount = TimerQueue.TickCount64;
				num = int.MaxValue;
				using (@lock.EnterScope())
				{
					for (int i = list2.Count - 1; i >= 0; i--)
					{
						TimerQueue timerQueue = list2[i];
						long num2 = timerQueue._scheduledDueTimeMs - tickCount;
						if (num2 <= 0L)
						{
							timerQueue._isScheduled = false;
							list.Add(timerQueue);
							int num3 = list2.Count - 1;
							if (i != num3)
							{
								list2[i] = list2[num3];
							}
							list2.RemoveAt(num3);
						}
						else if (num2 < (long)num)
						{
							num = (int)num2;
						}
					}
				}
				if (list.Count > 0)
				{
					foreach (TimerQueue callBack in list)
					{
						ThreadPool.UnsafeQueueHighPriorityWorkItemInternal(callBack);
					}
					list.Clear();
				}
				if (num == 2147483647)
				{
					num = -1;
				}
			}
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x000DE3F0 File Offset: 0x000DC5F0
		void IThreadPoolWorkItem.Execute()
		{
			this.FireNextTimers();
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x000DE3F8 File Offset: 0x000DC5F8
		private TimerQueue(int id)
		{
			this._id = id;
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x000DE424 File Offset: 0x000DC624
		private bool SetTimer(uint actualDuration)
		{
			if (!ThreadPool.UseWindowsThreadPool)
			{
				return this.SetTimerPortable(actualDuration);
			}
			return this.SetTimerWindowsThreadPool(actualDuration);
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x000DE43C File Offset: 0x000DC63C
		public static long TickCount64
		{
			get
			{
				if (Environment.IsWindows8OrAbove)
				{
					ulong num;
					Interop.Kernel32.QueryUnbiasedInterruptTime(out num);
					return (long)(num / 10000UL);
				}
				return Environment.TickCount64;
			}
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x000DE468 File Offset: 0x000DC668
		[UnmanagedCallersOnly]
		private unsafe static void TimerCallbackWindowsThreadPool(void* instance, void* context, void* timer)
		{
			int num = context;
			ThreadPoolCallbackWrapper threadPoolCallbackWrapper = ThreadPoolCallbackWrapper.Enter();
			TimerQueue.Instances[num].FireNextTimers();
			ThreadPool.IncrementCompletedWorkItemCount();
			threadPoolCallbackWrapper.Exit(true);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x000DE498 File Offset: 0x000DC698
		private unsafe bool SetTimerWindowsThreadPool(uint actualDuration)
		{
			if (this._nativeTimer == IntPtr.Zero)
			{
				this._nativeTimer = Interop.Kernel32.CreateThreadpoolTimer(ldftn(TimerCallbackWindowsThreadPool), (char)((IntPtr)this._id), IntPtr.Zero);
				if (this._nativeTimer == IntPtr.Zero)
				{
					throw new OutOfMemoryException();
				}
			}
			long num = (long)(18446744073709541616UL * (ulong)actualDuration);
			Interop.Kernel32.SetThreadpoolTimer(this._nativeTimer, &num, 0U, 0U);
			return true;
		}

		// Token: 0x04000E7D RID: 3709
		[TupleElementNames(new string[]
		{
			"TickCount",
			"Time"
		})]
		internal static readonly ValueTuple<long, DateTime> s_tickCountToTimeMap = new ValueTuple<long, DateTime>(TimerQueue.TickCount64, DateTime.UtcNow);

		// Token: 0x04000E7F RID: 3711
		private bool _isTimerScheduled;

		// Token: 0x04000E80 RID: 3712
		private long _currentTimerStartTicks;

		// Token: 0x04000E81 RID: 3713
		private uint _currentTimerDuration;

		// Token: 0x04000E82 RID: 3714
		private TimerQueueTimer _shortTimers;

		// Token: 0x04000E83 RID: 3715
		private TimerQueueTimer _longTimers;

		// Token: 0x04000E84 RID: 3716
		private long _currentAbsoluteThreshold = TimerQueue.TickCount64 + 333L;

		// Token: 0x04000E87 RID: 3719
		private static List<TimerQueue> s_scheduledTimers;

		// Token: 0x04000E88 RID: 3720
		private static List<TimerQueue> s_scheduledTimersToFire;

		// Token: 0x04000E89 RID: 3721
		private static readonly AutoResetEvent s_timerEvent = new AutoResetEvent(false);

		// Token: 0x04000E8A RID: 3722
		private static readonly Lock s_timerEventLock = new Lock();

		// Token: 0x04000E8B RID: 3723
		private bool _isScheduled;

		// Token: 0x04000E8C RID: 3724
		private long _scheduledDueTimeMs;

		// Token: 0x04000E8D RID: 3725
		private IntPtr _nativeTimer;

		// Token: 0x04000E8E RID: 3726
		private readonly int _id;

		// Token: 0x02000447 RID: 1095
		private sealed class TimerQueueDebuggerTypeProxy
		{
			// Token: 0x0600429A RID: 17050 RVA: 0x000DE533 File Offset: 0x000DC733
			public TimerQueueDebuggerTypeProxy(TimerQueue queue)
			{
				ArgumentNullException.ThrowIfNull(queue, "queue");
				this._queue = queue;
			}

			// Token: 0x17000BFF RID: 3071
			// (get) Token: 0x0600429B RID: 17051 RVA: 0x000DE54D File Offset: 0x000DC74D
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public TimerQueueTimer[] Items
			{
				get
				{
					return new List<TimerQueueTimer>(this._queue.GetTimersForDebugger()).ToArray();
				}
			}

			// Token: 0x04000E8F RID: 3727
			private readonly TimerQueue _queue;
		}

		// Token: 0x02000448 RID: 1096
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000E90 RID: 3728
			public static ThreadStart <0>__TimerThread;
		}
	}
}
