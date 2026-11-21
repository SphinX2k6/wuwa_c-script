using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020003F8 RID: 1016
	[StructLayout(LayoutKind.Auto)]
	internal struct LowLevelMonitor
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x000D779A File Offset: 0x000D599A
		public void Dispose()
		{
			this.DisposeCore();
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x000D77A2 File Offset: 0x000D59A2
		public void Acquire()
		{
			this.AcquireCore();
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x000D77AA File Offset: 0x000D59AA
		public void Release()
		{
			this.ReleaseCore();
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x000D77B2 File Offset: 0x000D59B2
		public void Wait()
		{
			this.WaitCore();
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x000D77BA File Offset: 0x000D59BA
		public void Signal_Release()
		{
			this.Signal_ReleaseCore();
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x000D77C2 File Offset: 0x000D59C2
		public unsafe void Initialize()
		{
			this._pMonitor = Marshal.AllocHGlobal(sizeof(LowLevelMonitor.Monitor));
			Interop.Kernel32.InitializeCriticalSection(&this._pMonitor->_criticalSection);
			Interop.Kernel32.InitializeConditionVariable(&this._pMonitor->_conditionVariable);
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x000D77F7 File Offset: 0x000D59F7
		private unsafe void DisposeCore()
		{
			if (this._pMonitor == null)
			{
				return;
			}
			Interop.Kernel32.DeleteCriticalSection(&this._pMonitor->_criticalSection);
			Marshal.FreeHGlobal(this._pMonitor);
			this._pMonitor = null;
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x000D7828 File Offset: 0x000D5A28
		private unsafe void AcquireCore()
		{
			Interop.Kernel32.EnterCriticalSection(&this._pMonitor->_criticalSection);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x000D783B File Offset: 0x000D5A3B
		private unsafe void ReleaseCore()
		{
			Interop.Kernel32.LeaveCriticalSection(&this._pMonitor->_criticalSection);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x000D784E File Offset: 0x000D5A4E
		private void WaitCore()
		{
			this.WaitCore(-1);
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x000D7858 File Offset: 0x000D5A58
		private unsafe bool WaitCore(int timeoutMilliseconds)
		{
			return Interop.Kernel32.SleepConditionVariableCS(&this._pMonitor->_conditionVariable, &this._pMonitor->_criticalSection, timeoutMilliseconds);
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x000D7878 File Offset: 0x000D5A78
		private unsafe void Signal_ReleaseCore()
		{
			Interop.Kernel32.WakeConditionVariable(&this._pMonitor->_conditionVariable);
			Interop.Kernel32.LeaveCriticalSection(&this._pMonitor->_criticalSection);
		}

		// Token: 0x04000D88 RID: 3464
		private unsafe LowLevelMonitor.Monitor* _pMonitor;

		// Token: 0x020003F9 RID: 1017
		internal struct Monitor
		{
			// Token: 0x04000D89 RID: 3465
			public Interop.Kernel32.CRITICAL_SECTION _criticalSection;

			// Token: 0x04000D8A RID: 3466
			public Interop.Kernel32.CONDITION_VARIABLE _conditionVariable;
		}
	}
}
