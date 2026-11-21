using System;
using System.Runtime.CompilerServices;

// Token: 0x02001CA1 RID: 7329
[NullableContext(1)]
[Nullable(0)]
public readonly struct RoleTowerDataTableConfig : IRoleTowerDataTableConfig
{
	// Token: 0x17001B61 RID: 7009
	// (get) Token: 0x0601226C RID: 74348 RVA: 0x0055834D File Offset: 0x0055654D
	public string Path { get; }

	// Token: 0x17001B62 RID: 7010
	// (get) Token: 0x0601226D RID: 74349 RVA: 0x00558355 File Offset: 0x00556555
	public string PropertyName { get; }

	// Token: 0x0601226E RID: 74350 RVA: 0x0055835D File Offset: 0x0055655D
	public RoleTowerDataTableConfig(string path, string propertyName)
	{
		this.Path = path;
		this.PropertyName = propertyName;
	}
}
