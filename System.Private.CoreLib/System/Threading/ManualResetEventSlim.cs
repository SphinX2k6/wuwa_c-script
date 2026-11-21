using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Threading
{
	// Token: 0x020003FB RID: 1019
	[DebuggerDisplay("Set = {IsSet}")]
	public class ManualResetEventSlim : IDisposable
	{
		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x000D78A6 File Offset: 0x000D5AA6
		[Nullable(1)]
		public WaitHandle WaitHandle
		{
			[NullableContext(1)]
			get
			{
				ObjectDisposedException.ThrowIf(this.IsDisposed, this);
				if (this.m_eventObj == null)
				{
					this.LazyInitializeEvent();
				}
				return this.m_eventObj;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x000D78CC File Offset: 0x000D5ACC
		// (set) Token: 0x060040A6 RID: 16550 RVA: 0x000D78E3 File Offset: 0x000D5AE3
		public bool IsSet
		{
			get
			{
				return ManualResetEventSlim.ExtractStatePortion(this.m_combinedState, int.MinValue) != 0;
			}
			private set
			{
				this.UpdateStateAtomically((((value > false) ? 1 : 0) << 31) ? 1 : 0, int.MinValue);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x000D78F7 File Offset: 0x000D5AF7
		// (set) Token: 0x060040A8 RID: 16552 RVA: 0x000D790D File Offset: 0x000D5B0D
		public int SpinCount
		{
			get
			{
				return ManualResetEventSlim.ExtractStatePortionAndShiftRight(this.m_combinedState, 1073217536, 19);
			}
			private set
			{
				this.m_combinedState = ((this.m_combinedState & -1073217537) | value << 19);
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x000D792A File Offset: 0x000D5B2A
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x000D793F File Offset: 0x000D5B3F
		private int Waiters
		{
			get
			{
				return ManualResetEventSlim.ExtractStatePortionAndShiftRight(this.m_combinedState, 524287, 0);
			}
			set
			{
				if (value >= 524287)
				{
					throw new InvalidOperationException(SR.Format(SR.ManualResetEventSlim_ctor_TooManyWaiters, 524287));
				}
				this.UpdateStateAtomically(value, 524287);
			}
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x000D796F File Offset: 0x000D5B6F
		public ManualResetEventSlim() : this(false)
		{
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x000D7978 File Offset: 0x000D5B78
		public ManualResetEventSlim(bool initialState)
		{
			this.Initialize(initialState, SpinWait.SpinCountforSpinBeforeWait);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x000D798C File Offset: 0x000D5B8C
		public ManualResetEventSlim(bool initialState, int spinCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(spinCount, "spinCount");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(spinCount, 2047, "spinCount");
			this.Initialize(initialState, spinCount);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x000D79B7 File Offset: 0x000D5BB7
		private void Initialize(bool initialState, int spinCount)
		{
			this.m_combinedState = (initialState ? int.MinValue : 0);
			this.SpinCount = (Environment.IsSingleProcessor ? 1 : spinCount);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x000D79DD File Offset: 0x000D5BDD
		[MemberNotNull("m_lock")]
		private void EnsureLockObjectCreated()
		{
			if (this.m_lock == null)
			{
				Interlocked.CompareExchange(ref this.m_lock, new object(), null);
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x000D79FC File Offset: 0x000D5BFC
		private void LazyInitializeEvent()
		{
			bool isSet = this.IsSet;
			ManualResetEvent manualResetEvent = new ManualResetEvent(isSet);
			if (Interlocked.CompareExchange<ManualResetEvent>(ref this.m_eventObj, manualResetEvent, null) != null)
			{
				manualResetEvent.Dispose();
				return;
			}
			if (this.IsSet != isSet)
			{
				ManualResetEvent obj = manualResetEvent;
				lock (obj)
				{
					if (this.m_eventObj == manualResetEvent)
					{
						manualResetEvent.Set();
					}
				}
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x000D7A70 File Offset: 0x000D5C70
		public void Set()
		{
			this.Set(false);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x000D7A7C File Offset: 0x000D5C7C
		private void Set(bool duringCancellation)
		{
			this.IsSet = true;
			if (this.Waiters > 0)
			{
				object @lock = this.m_lock;
				lock (@lock)
				{
					Monitor.PulseAll(this.m_lock);
				}
			}
			ManualResetEvent eventObj = this.m_eventObj;
			if (eventObj != null && !duringCancellation)
			{
				ManualResetEvent obj = eventObj;
				lock (obj)
				{
					ManualResetEvent eventObj2 = this.m_eventObj;
					if (eventObj2 != null)
					{
						eventObj2.Set();
					}
				}
			}
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x000D7B18 File Offset: 0x000D5D18
		public void Reset()
		{
			ObjectDisposedException.ThrowIf(this.IsDisposed, this);
			ManualResetEvent eventObj = this.m_eventObj;
			if (eventObj != null)
			{
				eventObj.Reset();
			}
			this.IsSet = false;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x000D7B41 File Offset: 0x000D5D41
		[UnsupportedOSPlatform("browser")]
		public void Wait()
		{
			this.Wait(-1, CancellationToken.None);
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x000D7B50 File Offset: 0x000D5D50
		[UnsupportedOSPlatform("browser")]
		public void Wait(CancellationToken cancellationToken)
		{
			this.Wait(-1, cancellationToken);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x000D7B5C File Offset: 0x000D5D5C
		[UnsupportedOSPlatform("browser")]
		public bool Wait(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "timeout");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, 2147483647L, "timeout");
			return this.Wait((int)num, CancellationToken.None);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x000D7BA0 File Offset: 0x000D5DA0
		[UnsupportedOSPlatform("browser")]
		public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "timeout");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, 2147483647L, "timeout");
			return this.Wait((int)num, cancellationToken);
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x000D7BDD File Offset: 0x000D5DDD
		[UnsupportedOSPlatform("browser")]
		public bool Wait(int millisecondsTimeout)
		{
			return this.Wait(millisecondsTimeout, CancellationToken.None);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x000D7BEC File Offset: 0x000D5DEC
		[UnsupportedOSPlatform("browser")]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			ObjectDisposedException.ThrowIf(this.IsDisposed, this);
			cancellationToken.ThrowIfCancellationRequested();
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			if (!this.IsSet)
			{
				if (millisecondsTimeout == 0)
				{
					return false;
				}
				uint startTime = 0U;
				bool flag = false;
				int num = millisecondsTimeout;
				if (millisecondsTimeout != -1)
				{
					startTime = TimeoutHelper.GetTime();
					flag = true;
				}
				int spinCount = this.SpinCount;
				SpinWait spinWait = default(SpinWait);
				while (spinWait.Count < spinCount)
				{
					spinWait.SpinOnce(-1);
					if (this.IsSet)
					{
						return true;
					}
					if (spinWait.Count >= 100 && spinWait.Count % 10 == 0)
					{
						cancellationToken.ThrowIfCancellationRequested();
					}
				}
				this.EnsureLockObjectCreated();
				using (cancellationToken.UnsafeRegister(ManualResetEventSlim.s_cancellationTokenCallback, this))
				{
					object @lock = this.m_lock;
					lock (@lock)
					{
						while (!this.IsSet)
						{
							cancellationToken.ThrowIfCancellationRequested();
							if (flag)
							{
								num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
								if (num <= 0)
								{
									return false;
								}
							}
							int waiters = this.Waiters;
							this.Waiters = waiters + 1;
							if (this.IsSet)
							{
								waiters = this.Waiters;
								this.Waiters = waiters - 1;
								return true;
							}
							try
							{
								if (!Monitor.Wait(this.m_lock, num))
								{
									return false;
								}
							}
							finally
							{
								waiters = this.Waiters;
								this.Waiters = waiters - 1;
							}
						}
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x000D7D78 File Offset: 0x000D5F78
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x000D7D88 File Offset: 0x000D5F88
		protected virtual void Dispose(bool disposing)
		{
			if ((this.m_combinedState & 1073741824) != 0)
			{
				return;
			}
			this.m_combinedState |= 1073741824;
			if (disposing)
			{
				ManualResetEvent eventObj = this.m_eventObj;
				if (eventObj != null)
				{
					ManualResetEvent obj = eventObj;
					lock (obj)
					{
						eventObj.Dispose();
						this.m_eventObj = null;
					}
				}
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x000D7E04 File Offset: 0x000D6004
		private bool IsDisposed
		{
			get
			{
				return (this.m_combinedState & 1073741824) != 0;
			}
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x000D7E18 File Offset: 0x000D6018
		private static void CancellationTokenCallback(object obj)
		{
			ManualResetEventSlim manualResetEventSlim = (ManualResetEventSlim)obj;
			object @lock = manualResetEventSlim.m_lock;
			lock (@lock)
			{
				Monitor.PulseAll(manualResetEventSlim.m_lock);
			}
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x000D7E64 File Offset: 0x000D6064
		private void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int combinedState = this.m_combinedState;
				int value = (combinedState & ~updateBitsMask) | newBits;
				if (Interlocked.CompareExchange(ref this.m_combinedState, value, combinedState) == combinedState)
				{
					break;
				}
				spinWait.SpinOnce(-1);
			}
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x000D7EA3 File Offset: 0x000D60A3
		private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			return (int)((uint)(state & mask) >> rightBitShiftCount);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00040597 File Offset: 0x0003E797
		private static int ExtractStatePortion(int state, int mask)
		{
			return state & mask;
		}

		// Token: 0x04000D8B RID: 3467
		private object m_lock;

		// Token: 0x04000D8C RID: 3468
		private volatile ManualResetEvent m_eventObj;

		// Token: 0x04000D8D RID: 3469
		private volatile int m_combinedState;

		// Token: 0x04000D8E RID: 3470
		private static readonly Action<object> s_cancellationTokenCallback = new Action<object>(ManualResetEventSlim.CancellationTokenCallback);
	}
}
