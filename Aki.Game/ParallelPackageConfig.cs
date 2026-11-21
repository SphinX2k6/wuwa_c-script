using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017FA RID: 6138
public class ParallelPackageConfig
{
	// Token: 0x040087EF RID: 34799
	public int version;

	// Token: 0x040087F0 RID: 34800
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ParallelPackageUrlConfig> packageConfig;

	// Token: 0x040087F1 RID: 34801
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, ParallelPackageLanguageContent> languageConfig;
}
