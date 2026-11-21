using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001ED RID: 493
	[NullableContext(1)]
	[Nullable(0)]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x00078128 File Offset: 0x00076328
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
			this._exception = exception;
			this._isTerminating = isTerminating;
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x0007813E File Offset: 0x0007633E
		public object ExceptionObject
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x00078146 File Offset: 0x00076346
		public bool IsTerminating
		{
			get
			{
				return this._isTerminating;
			}
		}

		// Token: 0x040006EF RID: 1775
		private readonly object _exception;

		// Token: 0x040006F0 RID: 1776
		private readonly bool _isTerminating;
	}
}
