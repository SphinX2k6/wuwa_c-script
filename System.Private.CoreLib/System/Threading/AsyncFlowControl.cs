using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003EA RID: 1002
	public struct AsyncFlowControl : IEquatable<AsyncFlowControl>, IDisposable
	{
		// Token: 0x06004026 RID: 16422 RVA: 0x000D6583 File Offset: 0x000D4783
		internal void Initialize(Thread currentThread)
		{
			this._thread = currentThread;
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x000D658C File Offset: 0x000D478C
		public void Undo()
		{
			if (this._thread == null)
			{
				return;
			}
			if (Thread.CurrentThread != this._thread)
			{
				throw new InvalidOperationException(SR.InvalidOperation_CannotUseAFCOtherThread);
			}
			if (!ExecutionContext.IsFlowSuppressed())
			{
				throw new InvalidOperationException(SR.InvalidOperation_AsyncFlowCtrlCtxMismatch);
			}
			this._thread = null;
			ExecutionContext.RestoreFlow();
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x000D65D8 File Offset: 0x000D47D8
		public void Dispose()
		{
			this.Undo();
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x000D65E0 File Offset: 0x000D47E0
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is AsyncFlowControl)
			{
				AsyncFlowControl obj2 = (AsyncFlowControl)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x000D6605 File Offset: 0x000D4805
		public bool Equals(AsyncFlowControl obj)
		{
			return this._thread == obj._thread;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x000D6615 File Offset: 0x000D4815
		public override int GetHashCode()
		{
			Thread thread = this._thread;
			if (thread == null)
			{
				return 0;
			}
			return thread.GetHashCode();
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x000D6628 File Offset: 0x000D4828
		public static bool operator ==(AsyncFlowControl a, AsyncFlowControl b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x000D6632 File Offset: 0x000D4832
		public static bool operator !=(AsyncFlowControl a, AsyncFlowControl b)
		{
			return !(a == b);
		}

		// Token: 0x04000D65 RID: 3429
		private Thread _thread;
	}
}
