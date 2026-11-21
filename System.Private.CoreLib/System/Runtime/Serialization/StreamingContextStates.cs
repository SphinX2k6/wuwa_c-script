using System;

namespace System.Runtime.Serialization
{
	// Token: 0x0200052B RID: 1323
	[Flags]
	[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public enum StreamingContextStates
	{
		// Token: 0x04001175 RID: 4469
		CrossProcess = 1,
		// Token: 0x04001176 RID: 4470
		CrossMachine = 2,
		// Token: 0x04001177 RID: 4471
		File = 4,
		// Token: 0x04001178 RID: 4472
		Persistence = 8,
		// Token: 0x04001179 RID: 4473
		Remoting = 16,
		// Token: 0x0400117A RID: 4474
		Other = 32,
		// Token: 0x0400117B RID: 4475
		Clone = 64,
		// Token: 0x0400117C RID: 4476
		CrossAppDomain = 128,
		// Token: 0x0400117D RID: 4477
		All = 255
	}
}
