using System;

namespace System
{
	// Token: 0x02000160 RID: 352
	public enum LoaderOptimization
	{
		// Token: 0x040004E1 RID: 1249
		[Obsolete("LoaderOptimization.DisallowBindings has been deprecated and is not supported.")]
		DisallowBindings = 4,
		// Token: 0x040004E2 RID: 1250
		[Obsolete("LoaderOptimization.DomainMask has been deprecated and is not supported.")]
		DomainMask = 3,
		// Token: 0x040004E3 RID: 1251
		MultiDomain = 2,
		// Token: 0x040004E4 RID: 1252
		MultiDomainHost,
		// Token: 0x040004E5 RID: 1253
		NotSpecified = 0,
		// Token: 0x040004E6 RID: 1254
		SingleDomain
	}
}
