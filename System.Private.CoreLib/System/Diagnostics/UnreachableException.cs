using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x02000891 RID: 2193
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class UnreachableException : Exception
	{
		// Token: 0x0600898E RID: 35214 RVA: 0x0014E31E File Offset: 0x0014C51E
		public UnreachableException() : base(SR.Arg_UnreachableException)
		{
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x0014E32B File Offset: 0x0014C52B
		public UnreachableException(string message) : base(message ?? SR.Arg_UnreachableException)
		{
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x0014E33D File Offset: 0x0014C53D
		public UnreachableException(string message, Exception innerException) : base(message ?? SR.Arg_UnreachableException, innerException)
		{
		}
	}
}
