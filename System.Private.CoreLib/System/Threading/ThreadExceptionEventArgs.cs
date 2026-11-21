using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x02000419 RID: 1049
	[NullableContext(1)]
	[Nullable(0)]
	public class ThreadExceptionEventArgs : EventArgs
	{
		// Token: 0x0600419B RID: 16795 RVA: 0x000DAE41 File Offset: 0x000D9041
		public ThreadExceptionEventArgs(Exception t)
		{
			this.m_exception = t;
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x000DAE50 File Offset: 0x000D9050
		public Exception Exception
		{
			get
			{
				return this.m_exception;
			}
		}

		// Token: 0x04000DF5 RID: 3573
		private readonly Exception m_exception;
	}
}
