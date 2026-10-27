using System;
using System.Runtime.CompilerServices;

// Token: 0x0200315A RID: 12634
public class ILogicalStructure
{
	// Token: 0x0400D39B RID: 54171
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ILogicalStructure[] And;

	// Token: 0x0400D39C RID: 54172
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ILogicalStructure[] Or;

	// Token: 0x0400D39D RID: 54173
	[Nullable(2)]
	public ILogicalStructure Not;

	// Token: 0x0400D39E RID: 54174
	public int? Index;
}
