using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime
{
	// Token: 0x020004F9 RID: 1273
	public static class ControlledExecution
	{
		// Token: 0x06004811 RID: 18449 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(1)]
		[Obsolete("ControlledExecution.Run method may corrupt the process and should not be used in production code.", DiagnosticId = "SYSLIB0046", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void Run(Action action, CancellationToken cancellationToken)
		{
			throw new PlatformNotSupportedException();
		}
	}
}
