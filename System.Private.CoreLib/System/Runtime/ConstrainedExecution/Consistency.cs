using System;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x02000531 RID: 1329
	[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public enum Consistency
	{
		// Token: 0x04001187 RID: 4487
		MayCorruptProcess,
		// Token: 0x04001188 RID: 4488
		MayCorruptAppDomain,
		// Token: 0x04001189 RID: 4489
		MayCorruptInstance,
		// Token: 0x0400118A RID: 4490
		WillNotCorruptState
	}
}
