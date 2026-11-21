using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x0200044A RID: 1098
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(TimerQueueTimer.TimerDebuggerTypeProxy))]
	internal sealed class TimerQueueTimer : ITimer, IDisposable, IAsyncDisposable, IThreadPoolWorkItem
	{
		// Token: 0x060042A4 RID: 17060 RVA: 0x000DE69F File Offset: 0x000DC89F
		internal TimerQueueTimer(TimerCallback timerCallback, object state, TimeSpan dueTime, TimeSpan period, bool flowExecutionContext) : this(timerCallback, state, TimerQueueTimer.GetMilliseconds(dueTime, "dueTime"), TimerQueueTimer.GetMilliseconds(period, "period"), flowExecutionContext)
		{
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x000DE6C2 File Offset: 0x000DC8C2
		private static uint GetMilliseconds(TimeSpan time, [CallerArgumentExpression("time")] string parameter = null)
		{
			long num = (long)time.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, parameter);
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, (long)((ulong)-2), parameter);
			return (uint)num;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x000DE6E0 File Offset: 0x000DC8E0
		internal TimerQueueTimer(TimerCallback timerCallback, object state, uint dueTime, uint period, bool flowExecutionContext)
		{
			this._timerCallback = timerCallback;
			this._state = state;
			this._dueTime = uint.MaxValue;
			this._period = uint.MaxValue;
			if (flowExecutionContext)
			{
				this._executionContext = ExecutionContext.Capture();
			}
			this._associatedTimerQueue = TimerQueue.Instances[(int)(checked((IntPtr)(unchecked((ulong)Thread.GetCurrentProcessorId() % (ulong)((long)TimerQueue.Instances.Length)))))];
			if (dueTime != 4294967295U)
			{
				this.Change(dueTime, period);
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x000DE748 File Offset: 0x000DC948
		internal string DisplayString
		{
			get
			{
				Type declaringType = this._timerCallback.Method.DeclaringType;
				string text = (declaringType != null) ? declaringType.FullName : null;
				if (text != null)
				{
					text += ".";
				}
				string[] array = new string[10];
				array[0] = "DueTime = ";
				int num = 1;
				string text2 = (this._dueTime == uint.MaxValue) ? "(not set)" : TimeSpan.FromMilliseconds((long)((ulong)this._dueTime), 0L);
				array[num] = ((text2 != null) ? text2.ToString() : null);
				array[2] = ", Period = ";
				int num2 = 3;
				string text3 = (this._period == uint.MaxValue) ? "(not set)" : TimeSpan.FromMilliseconds((long)((ulong)this._period), 0L);
				array[num2] = ((text3 != null) ? text3.ToString() : null);
				array[4] = ", ";
				array[5] = text;
				array[6] = this._timerCallback.Method.Name;
				array[7] = "(";
				int num3 = 8;
				object state = this._state;
				array[num3] = (((state != null) ? state.ToString() : null) ?? "null");
				array[9] = ")";
				return string.Concat(array);
			}
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000DE84F File Offset: 0x000DCA4F
		public bool Change(TimeSpan dueTime, TimeSpan period)
		{
			return this.Change(TimerQueueTimer.GetMilliseconds(dueTime, "dueTime"), TimerQueueTimer.GetMilliseconds(period, "period"));
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000DE870 File Offset: 0x000DCA70
		internal bool Change(uint dueTime, uint period)
		{
			bool result;
			using (this._associatedTimerQueue.SharedLock.EnterScope())
			{
				if (this._canceled)
				{
					return false;
				}
				this._period = period;
				if (dueTime == 4294967295U)
				{
					this._associatedTimerQueue.DeleteTimer(this);
					result = true;
				}
				else
				{
					if (FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
					{
						FrameworkEventSource.Log.ThreadTransferSendObj(this, 1, string.Empty, true, (int)dueTime, (int)period);
					}
					result = this._associatedTimerQueue.UpdateTimer(this, dueTime, period);
				}
			}
			return result;
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x000DE908 File Offset: 0x000DCB08
		public void Dispose()
		{
			using (this._associatedTimerQueue.SharedLock.EnterScope())
			{
				if (!this._canceled)
				{
					this._canceled = true;
					this._associatedTimerQueue.DeleteTimer(this);
				}
			}
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x000DE95C File Offset: 0x000DCB5C
		public bool Dispose(WaitHandle toSignal)
		{
			bool flag = false;
			bool result;
			using (this._associatedTimerQueue.SharedLock.EnterScope())
			{
				if (this._canceled)
				{
					result = false;
				}
				else
				{
					this._canceled = true;
					this._notifyWhenNoCallbacksRunning = toSignal;
					this._associatedTimerQueue.DeleteTimer(this);
					flag = (this._callbacksRunning == 0);
					result = true;
				}
			}
			if (flag)
			{
				this.SignalNoCallbacksRunning();
			}
			return result;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000DE9D4 File Offset: 0x000DCBD4
		public ValueTask DisposeAsync()
		{
			ValueTask result;
			using (this._associatedTimerQueue.SharedLock.EnterScope())
			{
				object notifyWhenNoCallbacksRunning = this._notifyWhenNoCallbacksRunning;
				if (this._canceled)
				{
					if (notifyWhenNoCallbacksRunning is WaitHandle)
					{
						InvalidOperationException ex = new InvalidOperationException(SR.InvalidOperation_TimerAlreadyClosed);
						ex.SetCurrentStackTrace();
						return ValueTask.FromException(ex);
					}
				}
				else
				{
					this._canceled = true;
					this._associatedTimerQueue.DeleteTimer(this);
				}
				if (this._callbacksRunning == 0)
				{
					result = default(ValueTask);
				}
				else if (notifyWhenNoCallbacksRunning == null)
				{
					Task task = new Task(null, TaskCreationOptions.RunContinuationsAsynchronously, true);
					this._notifyWhenNoCallbacksRunning = task;
					result = new ValueTask(task);
				}
				else
				{
					result = new ValueTask((Task)notifyWhenNoCallbacksRunning);
				}
			}
			return result;
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000DEA90 File Offset: 0x000DCC90
		void IThreadPoolWorkItem.Execute()
		{
			this.Fire(true);
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x000DEA9C File Offset: 0x000DCC9C
		internal void Fire(bool isThreadPool = false)
		{
			bool canceled;
			using (this._associatedTimerQueue.SharedLock.EnterScope())
			{
				canceled = this._canceled;
				if (!canceled)
				{
					this._callbacksRunning++;
				}
			}
			if (canceled)
			{
				return;
			}
			this.CallCallback(isThreadPool);
			bool flag;
			using (this._associatedTimerQueue.SharedLock.EnterScope())
			{
				this._callbacksRunning--;
				flag = (this._canceled && this._callbacksRunning == 0 && this._notifyWhenNoCallbacksRunning != null);
			}
			if (flag)
			{
				this.SignalNoCallbacksRunning();
			}
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x000DEB54 File Offset: 0x000DCD54
		internal void SignalNoCallbacksRunning()
		{
			object notifyWhenNoCallbacksRunning = this._notifyWhenNoCallbacksRunning;
			WaitHandle waitHandle = notifyWhenNoCallbacksRunning as WaitHandle;
			if (waitHandle != null)
			{
				EventWaitHandle.Set(waitHandle.SafeWaitHandle);
				return;
			}
			((Task)notifyWhenNoCallbacksRunning).TrySetResult();
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x000DEB8C File Offset: 0x000DCD8C
		internal void CallCallback(bool isThreadPool)
		{
			if (FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
			{
				FrameworkEventSource.Log.ThreadTransferReceiveObj(this, 1, string.Empty);
			}
			ExecutionContext executionContext = this._executionContext;
			if (executionContext == null)
			{
				this._timerCallback(this._state);
				return;
			}
			if (isThreadPool)
			{
				ExecutionContext.RunFromThreadPoolDispatchLoop(Thread.CurrentThread, executionContext, TimerQueueTimer.s_callCallbackInContext, this);
				return;
			}
			ExecutionContext.RunInternal(executionContext, TimerQueueTimer.s_callCallbackInContext, this);
		}

		// Token: 0x04000E96 RID: 3734
		private readonly TimerQueue _associatedTimerQueue;

		// Token: 0x04000E97 RID: 3735
		internal TimerQueueTimer _next;

		// Token: 0x04000E98 RID: 3736
		internal TimerQueueTimer _prev;

		// Token: 0x04000E99 RID: 3737
		internal bool _short;

		// Token: 0x04000E9A RID: 3738
		internal long _startTicks;

		// Token: 0x04000E9B RID: 3739
		internal uint _dueTime;

		// Token: 0x04000E9C RID: 3740
		internal uint _period;

		// Token: 0x04000E9D RID: 3741
		private readonly TimerCallback _timerCallback;

		// Token: 0x04000E9E RID: 3742
		private readonly object _state;

		// Token: 0x04000E9F RID: 3743
		private readonly ExecutionContext _executionContext;

		// Token: 0x04000EA0 RID: 3744
		private int _callbacksRunning;

		// Token: 0x04000EA1 RID: 3745
		private bool _canceled;

		// Token: 0x04000EA2 RID: 3746
		internal bool _everQueued;

		// Token: 0x04000EA3 RID: 3747
		private object _notifyWhenNoCallbacksRunning;

		// Token: 0x04000EA4 RID: 3748
		private static readonly ContextCallback s_callCallbackInContext = delegate(object state)
		{
			TimerQueueTimer timerQueueTimer = (TimerQueueTimer)state;
			timerQueueTimer._timerCallback(timerQueueTimer._state);
		};

		// Token: 0x0200044B RID: 1099
		internal sealed class TimerDebuggerTypeProxy
		{
			// Token: 0x060042B2 RID: 17074 RVA: 0x000DEC0E File Offset: 0x000DCE0E
			public TimerDebuggerTypeProxy(Timer timer)
			{
				this._timer = timer._timer._timer;
			}

			// Token: 0x060042B3 RID: 17075 RVA: 0x000DEC27 File Offset: 0x000DCE27
			public TimerDebuggerTypeProxy(TimerQueueTimer timer)
			{
				this._timer = timer;
			}

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x060042B4 RID: 17076 RVA: 0x000DEC38 File Offset: 0x000DCE38
			public DateTime? EstimatedNextTimeUtc
			{
				get
				{
					if (this._timer._dueTime != 4294967295U)
					{
						long milliseconds = this._timer._startTicks - TimerQueue.s_tickCountToTimeMap.Item1 + (long)((ulong)this._timer._dueTime);
						return new DateTime?(TimerQueue.s_tickCountToTimeMap.Item2 + TimeSpan.FromMilliseconds(milliseconds, 0L));
					}
					return null;
				}
			}

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x060042B5 RID: 17077 RVA: 0x000DECA0 File Offset: 0x000DCEA0
			public TimeSpan? DueTime
			{
				get
				{
					if (this._timer._dueTime != 4294967295U)
					{
						return new TimeSpan?(TimeSpan.FromMilliseconds((long)((ulong)this._timer._dueTime), 0L));
					}
					return null;
				}
			}

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x060042B6 RID: 17078 RVA: 0x000DECE0 File Offset: 0x000DCEE0
			public TimeSpan? Period
			{
				get
				{
					if (this._timer._period != 4294967295U)
					{
						return new TimeSpan?(TimeSpan.FromMilliseconds((long)((ulong)this._timer._period), 0L));
					}
					return null;
				}
			}

			// Token: 0x17000C06 RID: 3078
			// (get) Token: 0x060042B7 RID: 17079 RVA: 0x000DED1D File Offset: 0x000DCF1D
			public TimerCallback Callback
			{
				get
				{
					return this._timer._timerCallback;
				}
			}

			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x060042B8 RID: 17080 RVA: 0x000DED2A File Offset: 0x000DCF2A
			public object State
			{
				get
				{
					return this._timer._state;
				}
			}

			// Token: 0x04000EA5 RID: 3749
			private readonly TimerQueueTimer _timer;
		}
	}
}
