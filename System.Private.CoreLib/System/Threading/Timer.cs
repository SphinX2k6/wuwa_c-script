using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x0200044E RID: 1102
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(TimerQueueTimer.TimerDebuggerTypeProxy))]
	public sealed class Timer : MarshalByRefObject, IDisposable, IAsyncDisposable, ITimer
	{
		// Token: 0x060042C1 RID: 17089 RVA: 0x000DEDE6 File Offset: 0x000DCFE6
		public Timer(TimerCallback callback, [Nullable(2)] object state, int dueTime, int period) : this(callback, state, dueTime, period, true)
		{
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000DEDF4 File Offset: 0x000DCFF4
		internal Timer(TimerCallback callback, object state, int dueTime, int period, bool flowExecutionContext)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(dueTime, -1, "dueTime");
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(period, -1, "period");
			this.TimerSetup(callback, state, (uint)dueTime, (uint)period, flowExecutionContext);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x000DEE24 File Offset: 0x000DD024
		public Timer(TimerCallback callback, [Nullable(2)] object state, TimeSpan dueTime, TimeSpan period)
		{
			long num = (long)dueTime.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "dueTime");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, (long)((ulong)-2), "dueTime");
			long num2 = (long)period.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num2, -1L, "period");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num2, (long)((ulong)-2), "period");
			this.TimerSetup(callback, state, (uint)num, (uint)num2, true);
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x000DEE8C File Offset: 0x000DD08C
		[CLSCompliant(false)]
		public Timer(TimerCallback callback, [Nullable(2)] object state, uint dueTime, uint period)
		{
			this.TimerSetup(callback, state, dueTime, period, true);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x000DEEA0 File Offset: 0x000DD0A0
		public Timer(TimerCallback callback, [Nullable(2)] object state, long dueTime, long period)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(dueTime, -1L, "dueTime");
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(period, -1L, "period");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(dueTime, (long)((ulong)-2), "dueTime");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(period, (long)((ulong)-2), "period");
			this.TimerSetup(callback, state, (uint)dueTime, (uint)period, true);
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x000DEEF9 File Offset: 0x000DD0F9
		public Timer(TimerCallback callback)
		{
			this.TimerSetup(callback, this, uint.MaxValue, uint.MaxValue, true);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x000DEF0C File Offset: 0x000DD10C
		[MemberNotNull("_timer")]
		private void TimerSetup(TimerCallback callback, object state, uint dueTime, uint period, bool flowExecutionContext = true)
		{
			ArgumentNullException.ThrowIfNull(callback, "callback");
			this._timer = new TimerHolder(new TimerQueueTimer(callback, state, dueTime, period, flowExecutionContext));
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x000DEF30 File Offset: 0x000DD130
		public bool Change(int dueTime, int period)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(dueTime, -1, "dueTime");
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(period, -1, "period");
			return this._timer._timer.Change((uint)dueTime, (uint)period);
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x000DEF5C File Offset: 0x000DD15C
		public bool Change(TimeSpan dueTime, TimeSpan period)
		{
			return this._timer._timer.Change(dueTime, period);
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x000DEF70 File Offset: 0x000DD170
		[CLSCompliant(false)]
		public bool Change(uint dueTime, uint period)
		{
			return this._timer._timer.Change(dueTime, period);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x000DEF84 File Offset: 0x000DD184
		public bool Change(long dueTime, long period)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(dueTime, -1L, "dueTime");
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(period, -1L, "period");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(dueTime, (long)((ulong)-2), "dueTime");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(period, (long)((ulong)-2), "period");
			return this._timer._timer.Change((uint)dueTime, (uint)period);
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x000DEFDC File Offset: 0x000DD1DC
		public static long ActiveCount
		{
			get
			{
				long num = 0L;
				foreach (TimerQueue timerQueue in TimerQueue.Instances)
				{
					using (timerQueue.SharedLock.EnterScope())
					{
						num += timerQueue.ActiveCount;
					}
				}
				return num;
			}
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x000DF038 File Offset: 0x000DD238
		public bool Dispose(WaitHandle notifyObject)
		{
			ArgumentNullException.ThrowIfNull(notifyObject, "notifyObject");
			return this._timer.Dispose(notifyObject);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x000DF051 File Offset: 0x000DD251
		public void Dispose()
		{
			this._timer.Dispose();
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x000DF05E File Offset: 0x000DD25E
		public ValueTask DisposeAsync()
		{
			return this._timer.DisposeAsync();
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x000DF06B File Offset: 0x000DD26B
		private string DisplayString
		{
			get
			{
				return this._timer._timer.DisplayString;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x000DF080 File Offset: 0x000DD280
		private static IEnumerable<TimerQueueTimer> AllTimers
		{
			get
			{
				List<TimerQueueTimer> list = new List<TimerQueueTimer>();
				foreach (TimerQueue timerQueue in TimerQueue.Instances)
				{
					list.AddRange(timerQueue.GetTimersForDebugger());
				}
				list.Sort((TimerQueueTimer t1, TimerQueueTimer t2) => t1._dueTime.CompareTo(t2._dueTime));
				return list;
			}
		}

		// Token: 0x04000EA8 RID: 3752
		internal TimerHolder _timer;
	}
}
