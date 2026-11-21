using System;

namespace System.Threading
{
	// Token: 0x020003F6 RID: 1014
	internal sealed class LowLevelLock : IDisposable
	{
		// Token: 0x0600408A RID: 16522 RVA: 0x000D7545 File Offset: 0x000D5745
		public LowLevelLock()
		{
			this._spinWaiter = default(LowLevelSpinWaiter);
			this._monitor.Initialize();
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x000D7564 File Offset: 0x000D5764
		~LowLevelLock()
		{
			this.Dispose();
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x000D7590 File Offset: 0x000D5790
		public void Dispose()
		{
			this._monitor.Dispose();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x000D75A4 File Offset: 0x000D57A4
		public bool TryAcquire()
		{
			int num = Interlocked.CompareExchange(ref this._state, 1, 0);
			return num == 0 || this.TryAcquire_NoFastPath(num);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x000D75CE File Offset: 0x000D57CE
		private bool TryAcquire_NoFastPath(int state)
		{
			return (state & 1) == 0 && Interlocked.CompareExchange(ref this._state, state + 1, state) == state;
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x000D75E9 File Offset: 0x000D57E9
		private static bool SpinWaitTryAcquireCallback(object state)
		{
			LowLevelLock lowLevelLock = (LowLevelLock)state;
			return lowLevelLock.TryAcquire_NoFastPath(lowLevelLock._state);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x000D75FC File Offset: 0x000D57FC
		public void Acquire()
		{
			if (!this.TryAcquire())
			{
				this.WaitAndAcquire();
			}
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000D760C File Offset: 0x000D580C
		private void WaitAndAcquire()
		{
			if (this._spinWaiter.SpinWaitForCondition(LowLevelLock.s_spinWaitTryAcquireCallback, this, 8, 4))
			{
				return;
			}
			this._monitor.Acquire();
			int num = Interlocked.Add(ref this._state, 2);
			while ((num & 1) != 0 || Interlocked.CompareExchange(ref this._state, num + -1, num) != num)
			{
				this._monitor.Wait();
				this._isAnyWaitingThreadSignaled = false;
				num = this._state;
			}
			this._monitor.Release();
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x000D7684 File Offset: 0x000D5884
		public void Release()
		{
			if (Interlocked.Decrement(ref this._state) != 0)
			{
				this.SignalWaiter();
			}
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x000D7699 File Offset: 0x000D5899
		private void SignalWaiter()
		{
			this._monitor.Acquire();
			if (this._state >= 2 && !this._isAnyWaitingThreadSignaled)
			{
				this._isAnyWaitingThreadSignaled = true;
				this._monitor.Signal_Release();
				return;
			}
			this._monitor.Release();
		}

		// Token: 0x04000D82 RID: 3458
		private static readonly Func<object, bool> s_spinWaitTryAcquireCallback = new Func<object, bool>(LowLevelLock.SpinWaitTryAcquireCallback);

		// Token: 0x04000D83 RID: 3459
		private int _state;

		// Token: 0x04000D84 RID: 3460
		private bool _isAnyWaitingThreadSignaled;

		// Token: 0x04000D85 RID: 3461
		private LowLevelSpinWaiter _spinWaiter;

		// Token: 0x04000D86 RID: 3462
		private LowLevelMonitor _monitor;
	}
}
