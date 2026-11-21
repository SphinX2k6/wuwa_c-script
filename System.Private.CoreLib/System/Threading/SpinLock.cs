using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x0200040E RID: 1038
	[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
	[DebuggerDisplay("IsHeld = {IsHeld}")]
	public struct SpinLock
	{
		// Token: 0x0600415D RID: 16733 RVA: 0x000DA3F8 File Offset: 0x000D85F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int CompareExchange(ref int location, int value, int comparand, ref bool success)
		{
			int num = Interlocked.CompareExchange(ref location, value, comparand);
			success = (num == comparand);
			return num;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x000DA415 File Offset: 0x000D8615
		public SpinLock(bool enableThreadOwnerTracking)
		{
			this._owner = 0;
			if (!enableThreadOwnerTracking)
			{
				this._owner |= int.MinValue;
			}
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x000DA43C File Offset: 0x000D863C
		public void Enter(ref bool lockTaken)
		{
			int owner = this._owner;
			if (lockTaken || (owner & -2147483647) != -2147483648 || SpinLock.CompareExchange(ref this._owner, owner | 1, owner, ref lockTaken) != owner)
			{
				this.ContinueTryEnter(-1, ref lockTaken);
			}
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x000DA480 File Offset: 0x000D8680
		public void TryEnter(ref bool lockTaken)
		{
			int owner = this._owner;
			if ((owner & -2147483648) == 0 | lockTaken)
			{
				this.ContinueTryEnter(0, ref lockTaken);
				return;
			}
			if ((owner & 1) != 0)
			{
				lockTaken = false;
				return;
			}
			SpinLock.CompareExchange(ref this._owner, owner | 1, owner, ref lockTaken);
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x000DA4C8 File Offset: 0x000D86C8
		public void TryEnter(TimeSpan timeout, ref bool lockTaken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SR.SpinLock_TryEnter_ArgumentOutOfRange);
			}
			this.TryEnter((int)timeout.TotalMilliseconds, ref lockTaken);
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x000DA514 File Offset: 0x000D8714
		public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			int owner = this._owner;
			if ((millisecondsTimeout < -1 | lockTaken) || (owner & -2147483647) != -2147483648 || SpinLock.CompareExchange(ref this._owner, owner | 1, owner, ref lockTaken) != owner)
			{
				this.ContinueTryEnter(millisecondsTimeout, ref lockTaken);
			}
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x000DA55C File Offset: 0x000D875C
		private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			if (lockTaken)
			{
				lockTaken = false;
				throw new ArgumentException(SR.SpinLock_TryReliableEnter_ArgumentException);
			}
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, SR.SpinLock_TryEnter_ArgumentOutOfRange);
			}
			uint startTime = 0U;
			if (millisecondsTimeout != -1 && millisecondsTimeout != 0)
			{
				startTime = TimeoutHelper.GetTime();
			}
			if (this.IsThreadOwnerTrackingEnabled)
			{
				this.ContinueTryEnterWithThreadTracking(millisecondsTimeout, startTime, ref lockTaken);
				return;
			}
			int num = int.MaxValue;
			int owner = this._owner;
			if ((owner & 1) == 0)
			{
				if (SpinLock.CompareExchange(ref this._owner, owner | 1, owner, ref lockTaken) == owner)
				{
					return;
				}
				if (millisecondsTimeout == 0)
				{
					return;
				}
			}
			else
			{
				if (millisecondsTimeout == 0)
				{
					return;
				}
				if ((owner & 2147483646) != 2147483646)
				{
					num = (Interlocked.Add(ref this._owner, 2) & 2147483646) >> 1;
				}
			}
			SpinWait spinWait = default(SpinWait);
			if (num > Environment.ProcessorCount)
			{
				spinWait.Count = 10;
			}
			for (;;)
			{
				spinWait.SpinOnce(40);
				owner = this._owner;
				if ((owner & 1) == 0)
				{
					int value = ((owner & 2147483646) == 0) ? (owner | 1) : (owner - 2 | 1);
					if (SpinLock.CompareExchange(ref this._owner, value, owner, ref lockTaken) == owner)
					{
						break;
					}
				}
				if (spinWait.Count % 10 == 0 && millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0)
				{
					goto Block_17;
				}
			}
			return;
			Block_17:
			this.DecrementWaiters();
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000DA684 File Offset: 0x000D8884
		private void DecrementWaiters()
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int owner = this._owner;
				if ((owner & 2147483646) == 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this._owner, owner - 2, owner) == owner)
				{
					return;
				}
				spinWait.SpinOnce();
			}
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000DA6C8 File Offset: 0x000D88C8
		private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			if (this._owner == currentManagedThreadId)
			{
				throw new LockRecursionException(SR.SpinLock_TryEnter_LockRecursionException);
			}
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				spinWait.SpinOnce();
				if (this._owner == 0 && SpinLock.CompareExchange(ref this._owner, currentManagedThreadId, 0, ref lockTaken) == 0)
				{
					break;
				}
				if (millisecondsTimeout == 0 || (millisecondsTimeout != -1 && spinWait.NextSpinWillYield && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0))
				{
					return;
				}
			}
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x000DA735 File Offset: 0x000D8935
		public void Exit()
		{
			if ((this._owner & -2147483648) == 0)
			{
				this.ExitSlowPath(true);
				return;
			}
			Interlocked.Decrement(ref this._owner);
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x000DA75C File Offset: 0x000D895C
		public void Exit(bool useMemoryBarrier)
		{
			int owner = this._owner;
			if ((owner & -2147483648) != 0 & !useMemoryBarrier)
			{
				this._owner = (owner & -2);
				return;
			}
			this.ExitSlowPath(useMemoryBarrier);
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x000DA798 File Offset: 0x000D8998
		private void ExitSlowPath(bool useMemoryBarrier)
		{
			bool flag = (this._owner & int.MinValue) == 0;
			if (flag && !this.IsHeldByCurrentThread)
			{
				ThrowHelper.ThrowSynchronizationLockException_LockExit();
			}
			if (useMemoryBarrier)
			{
				if (flag)
				{
					Interlocked.Exchange(ref this._owner, 0);
					return;
				}
				Interlocked.Decrement(ref this._owner);
				return;
			}
			else
			{
				if (flag)
				{
					this._owner = 0;
					return;
				}
				int owner = this._owner;
				this._owner = (owner & -2);
				return;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x000DA80A File Offset: 0x000D8A0A
		public bool IsHeld
		{
			get
			{
				if (this.IsThreadOwnerTrackingEnabled)
				{
					return this._owner != 0;
				}
				return (this._owner & 1) != 0;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x000DA82D File Offset: 0x000D8A2D
		public bool IsHeldByCurrentThread
		{
			get
			{
				if (!this.IsThreadOwnerTrackingEnabled)
				{
					throw new InvalidOperationException(SR.SpinLock_IsHeldByCurrentThread);
				}
				return (this._owner & int.MaxValue) == Environment.CurrentManagedThreadId;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x000DA857 File Offset: 0x000D8A57
		public bool IsThreadOwnerTrackingEnabled
		{
			get
			{
				return (this._owner & int.MinValue) == 0;
			}
		}

		// Token: 0x04000DDF RID: 3551
		private volatile int _owner;

		// Token: 0x0200040F RID: 1039
		internal sealed class SystemThreading_SpinLockDebugView
		{
			// Token: 0x0600416C RID: 16748 RVA: 0x000DA86A File Offset: 0x000D8A6A
			public SystemThreading_SpinLockDebugView(SpinLock spinLock)
			{
				this._spinLock = spinLock;
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x0600416D RID: 16749 RVA: 0x000DA87C File Offset: 0x000D8A7C
			public bool? IsHeldByCurrentThread
			{
				get
				{
					bool? result;
					try
					{
						result = new bool?(this._spinLock.IsHeldByCurrentThread);
					}
					catch (InvalidOperationException)
					{
						result = null;
					}
					return result;
				}
			}

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x0600416E RID: 16750 RVA: 0x000DA8BC File Offset: 0x000D8ABC
			public int? OwnerThreadID
			{
				get
				{
					if (this._spinLock.IsThreadOwnerTrackingEnabled)
					{
						return new int?(this._spinLock._owner);
					}
					return null;
				}
			}

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x0600416F RID: 16751 RVA: 0x000DA8F2 File Offset: 0x000D8AF2
			public bool IsHeld
			{
				get
				{
					return this._spinLock.IsHeld;
				}
			}

			// Token: 0x04000DE0 RID: 3552
			private SpinLock _spinLock;
		}
	}
}
