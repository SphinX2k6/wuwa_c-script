using System;

namespace System.Security.Permissions
{
	// Token: 0x02000272 RID: 626
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public enum SecurityAction
	{
		// Token: 0x04000841 RID: 2113
		Assert = 3,
		// Token: 0x04000842 RID: 2114
		Demand = 2,
		// Token: 0x04000843 RID: 2115
		Deny = 4,
		// Token: 0x04000844 RID: 2116
		InheritanceDemand = 7,
		// Token: 0x04000845 RID: 2117
		LinkDemand = 6,
		// Token: 0x04000846 RID: 2118
		PermitOnly = 5,
		// Token: 0x04000847 RID: 2119
		RequestMinimum = 8,
		// Token: 0x04000848 RID: 2120
		RequestOptional,
		// Token: 0x04000849 RID: 2121
		RequestRefuse
	}
}
