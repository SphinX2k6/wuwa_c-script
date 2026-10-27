using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002315 RID: 8981
public class ParallelPackageConfig
{
	// Token: 0x040086AC RID: 34476
	public int version;

	// Token: 0x040086AD RID: 34477
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ParallelPackageUrlConfig> packageConfig;

	// Token: 0x040086AE RID: 34478
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, ParallelPackageLanguageContent> languageConfig;
}
