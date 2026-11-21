using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x02000416 RID: 1046
	internal struct ThreadBlockingInfo
	{
		// Token: 0x06004196 RID: 16790 RVA: 0x000DADAB File Offset: 0x000D8FAB
		private unsafe void Push(void* objectPtr, ThreadBlockingInfo.ObjectKind objectKind, int timeoutMs)
		{
			this._objectPtr = objectPtr;
			this._objectKind = objectKind;
			this._timeoutMs = timeoutMs;
			this._next = ThreadBlockingInfo.t_first;
			ThreadBlockingInfo.t_first = (ThreadBlockingInfo*)Unsafe.AsPointer<ThreadBlockingInfo>(ref this);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000DADD8 File Offset: 0x000D8FD8
		private void Pop()
		{
			ThreadBlockingInfo.t_first = this._next;
			this._objectPtr = null;
		}

		// Token: 0x04000DE9 RID: 3561
		[ThreadStatic]
		private unsafe static ThreadBlockingInfo* t_first;

		// Token: 0x04000DEA RID: 3562
		private unsafe void* _objectPtr;

		// Token: 0x04000DEB RID: 3563
		private ThreadBlockingInfo.ObjectKind _objectKind;

		// Token: 0x04000DEC RID: 3564
		private int _timeoutMs;

		// Token: 0x04000DED RID: 3565
		private unsafe ThreadBlockingInfo* _next;

		// Token: 0x02000417 RID: 1047
		[CompilerFeatureRequired("RefStructs")]
		public ref struct Scope
		{
			// Token: 0x06004198 RID: 16792 RVA: 0x000DADED File Offset: 0x000D8FED
			public Scope(Lock lockObj, int timeoutMs)
			{
				this = new ThreadBlockingInfo.Scope(lockObj, ThreadBlockingInfo.ObjectKind.Lock, timeoutMs);
			}

			// Token: 0x06004199 RID: 16793 RVA: 0x000DADF8 File Offset: 0x000D8FF8
			private Scope(object obj, ThreadBlockingInfo.ObjectKind objectKind, int timeoutMs)
			{
				this._blockingInfo = default(ThreadBlockingInfo);
				this._object = obj;
				this._blockingInfo.Push(Unsafe.AsPointer<object>(ref this._object), objectKind, timeoutMs);
			}

			// Token: 0x0600419A RID: 16794 RVA: 0x000DAE25 File Offset: 0x000D9025
			public void Dispose()
			{
				if (this._object != null)
				{
					this._blockingInfo.Pop();
					this._object = null;
				}
			}

			// Token: 0x04000DEE RID: 3566
			private object _object;

			// Token: 0x04000DEF RID: 3567
			private ThreadBlockingInfo _blockingInfo;
		}

		// Token: 0x02000418 RID: 1048
		public enum ObjectKind
		{
			// Token: 0x04000DF1 RID: 3569
			MonitorLock,
			// Token: 0x04000DF2 RID: 3570
			MonitorWait,
			// Token: 0x04000DF3 RID: 3571
			Lock,
			// Token: 0x04000DF4 RID: 3572
			Condition
		}
	}
}
