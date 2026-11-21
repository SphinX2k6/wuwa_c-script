using System;
using System.Runtime.CompilerServices;

// Token: 0x020026C7 RID: 9927
public class ILogicalStructure
{
	// Token: 0x0400D7FE RID: 55294
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ILogicalStructure[] And;

	// Token: 0x0400D7FF RID: 55295
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ILogicalStructure[] Or;

	// Token: 0x0400D800 RID: 55296
	[Nullable(2)]
	public ILogicalStructure Not;

	// Token: 0x0400D801 RID: 55297
	public int? Index;
}
