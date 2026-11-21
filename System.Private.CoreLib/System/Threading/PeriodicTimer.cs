using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Threading
{
	// Token: 0x02000441 RID: 1089
	public sealed class PeriodicTimer : IDisposable
	{
		// Token: 0x06004269 RID: 17001 RVA: 0x000DD858 File Offset: 0x000DBA58
		public PeriodicTimer(TimeSpan period)
		{
			uint num;
			if (!PeriodicTimer.TryGetMilliseconds(period, out num))
			{
				GC.SuppressFinalize(this);
				throw new ArgumentOutOfRangeException("period");
			}
			this._period = period;
			this._state = new PeriodicTimer.State();
			this._timer = new TimerQueueTimer(delegate(object s)
			{
				((PeriodicTimer.State)s).Signal(false, default(CancellationToken));
			}, this._state, num, num, false);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x000DD8CC File Offset: 0x000DBACC
		[NullableContext(1)]
		public PeriodicTimer(TimeSpan period, TimeProvider timeProvider)
		{
			uint num;
			if (!PeriodicTimer.TryGetMilliseconds(period, out num))
			{
				GC.SuppressFinalize(this);
				throw new ArgumentOutOfRangeException("period");
			}
			if (timeProvider == null)
			{
				GC.SuppressFinalize(this);
				throw new ArgumentNullException("timeProvider");
			}
			this._period = period;
			this._state = new PeriodicTimer.State();
			TimerCallback timerCallback = delegate(object s)
			{
				((PeriodicTimer.State)s).Signal(false, default(CancellationToken));
			};
			if (timeProvider == TimeProvider.System)
			{
				this._timer = new TimerQueueTimer(timerCallback, this._state, num, num, false);
				return;
			}
			using (ExecutionContext.SuppressFlow())
			{
				this._timer = timeProvider.CreateTimer(timerCallback, this._state, period, period);
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x000DD99C File Offset: 0x000DBB9C
		// (set) Token: 0x0600426C RID: 17004 RVA: 0x000DD9A4 File Offset: 0x000DBBA4
		public TimeSpan Period
		{
			get
			{
				return this._period;
			}
			set
			{
				uint num;
				if (!PeriodicTimer.TryGetMilliseconds(value, out num))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._period = value;
				if (!this._timer.Change(value, value))
				{
					ThrowHelper.ThrowObjectDisposedException(this);
				}
			}
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x000DD9E4 File Offset: 0x000DBBE4
		private static bool TryGetMilliseconds(TimeSpan value, out uint milliseconds)
		{
			long num = (long)value.TotalMilliseconds;
			if ((num >= 1L && num <= (long)((ulong)-2)) || value == Timeout.InfiniteTimeSpan)
			{
				milliseconds = (uint)num;
				return true;
			}
			milliseconds = 0U;
			return false;
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x000DDA1C File Offset: 0x000DBC1C
		public ValueTask<bool> WaitForNextTickAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return this._state.WaitForNextTickAsync(this, cancellationToken);
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x000DDA2C File Offset: 0x000DBC2C
		public void Dispose()
		{
			GC.SuppressFinalize(this);
			this._timer.Dispose();
			this._state.Signal(true, default(CancellationToken));
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000DDA60 File Offset: 0x000DBC60
		~PeriodicTimer()
		{
			this.Dispose();
		}

		// Token: 0x04000E6F RID: 3695
		private readonly ITimer _timer;

		// Token: 0x04000E70 RID: 3696
		private readonly PeriodicTimer.State _state;

		// Token: 0x04000E71 RID: 3697
		private TimeSpan _period;

		// Token: 0x02000442 RID: 1090
		private sealed class State : IValueTaskSource<bool>
		{
			// Token: 0x06004271 RID: 17009 RVA: 0x000DDA8C File Offset: 0x000DBC8C
			public ValueTask<bool> WaitForNextTickAsync(PeriodicTimer owner, CancellationToken cancellationToken)
			{
				ValueTask<bool> result;
				lock (this)
				{
					if (this._activeWait)
					{
						ThrowHelper.ThrowInvalidOperationException();
					}
					if (cancellationToken2.IsCancellationRequested)
					{
						result = ValueTask.FromCanceled<bool>(cancellationToken2);
					}
					else if (this._signaled)
					{
						if (!this._stopped)
						{
							this._signaled = false;
						}
						result = new ValueTask<bool>(!this._stopped);
					}
					else
					{
						this._owner = owner;
						this._activeWait = true;
						this._ctr = cancellationToken2.UnsafeRegister(delegate(object state, CancellationToken cancellationToken)
						{
							((PeriodicTimer.State)state).Signal(false, cancellationToken);
						}, this);
						result = new ValueTask<bool>(this, this._mrvtsc.Version);
					}
				}
				return result;
			}

			// Token: 0x06004272 RID: 17010 RVA: 0x000DDB5C File Offset: 0x000DBD5C
			public void Signal(bool stopping = false, CancellationToken cancellationToken = default(CancellationToken))
			{
				bool flag = false;
				lock (this)
				{
					this._stopped = (this._stopped || stopping);
					if (!this._signaled)
					{
						this._signaled = true;
						flag = this._activeWait;
					}
				}
				if (flag)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						this._mrvtsc.SetException(ExceptionDispatchInfo.SetCurrentStackTrace(new OperationCanceledException(cancellationToken)));
						return;
					}
					this._mrvtsc.SetResult(true);
				}
			}

			// Token: 0x06004273 RID: 17011 RVA: 0x000DDBE8 File Offset: 0x000DBDE8
			bool IValueTaskSource<bool>.GetResult(short token)
			{
				this._ctr.Dispose();
				bool result;
				lock (this)
				{
					try
					{
						this._mrvtsc.GetResult(token);
					}
					finally
					{
						this._mrvtsc.Reset();
						this._ctr = default(CancellationTokenRegistration);
						this._activeWait = false;
						this._owner = null;
						if (!this._stopped)
						{
							this._signaled = false;
						}
					}
					result = !this._stopped;
				}
				return result;
			}

			// Token: 0x06004274 RID: 17012 RVA: 0x000DDC84 File Offset: 0x000DBE84
			ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short token)
			{
				return this._mrvtsc.GetStatus(token);
			}

			// Token: 0x06004275 RID: 17013 RVA: 0x000DDC92 File Offset: 0x000DBE92
			void IValueTaskSource<bool>.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				this._mrvtsc.OnCompleted(continuation, state, token, flags);
			}

			// Token: 0x04000E72 RID: 3698
			private PeriodicTimer _owner;

			// Token: 0x04000E73 RID: 3699
			private ManualResetValueTaskSourceCore<bool> _mrvtsc;

			// Token: 0x04000E74 RID: 3700
			private CancellationTokenRegistration _ctr;

			// Token: 0x04000E75 RID: 3701
			private bool _stopped;

			// Token: 0x04000E76 RID: 3702
			private bool _signaled;

			// Token: 0x04000E77 RID: 3703
			private bool _activeWait;
		}
	}
}
