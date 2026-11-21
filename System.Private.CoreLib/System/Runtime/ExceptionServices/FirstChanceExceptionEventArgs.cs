using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.ExceptionServices
{
	// Token: 0x0200052E RID: 1326
	[NullableContext(1)]
	[Nullable(0)]
	public class FirstChanceExceptionEventArgs : EventArgs
	{
		// Token: 0x060048F3 RID: 18675 RVA: 0x000F203B File Offset: 0x000F023B
		public FirstChanceExceptionEventArgs(Exception exception)
		{
			this.Exception = exception;
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x000F204A File Offset: 0x000F024A
		public Exception Exception { get; }
	}
}
