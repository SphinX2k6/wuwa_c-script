using System;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x02000530 RID: 1328
	[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public enum Cer
	{
		// Token: 0x04001183 RID: 4483
		None,
		// Token: 0x04001184 RID: 4484
		MayFail,
		// Token: 0x04001185 RID: 4485
		Success
	}
}
