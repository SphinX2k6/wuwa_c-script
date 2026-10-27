using System;
using System.Runtime.CompilerServices;

// Token: 0x02000080 RID: 128
public interface IComponentDependency
{
	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060003FC RID: 1020
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Type[] Dependencies { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }
}
