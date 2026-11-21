using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000900 RID: 2304
	[Flags]
	public enum EventManifestOptions
	{
		// Token: 0x04002034 RID: 8244
		None = 0,
		// Token: 0x04002035 RID: 8245
		Strict = 1,
		// Token: 0x04002036 RID: 8246
		AllCultures = 2,
		// Token: 0x04002037 RID: 8247
		OnlyIfNeededForRegistration = 4,
		// Token: 0x04002038 RID: 8248
		AllowEventSourceOverride = 8
	}
}
