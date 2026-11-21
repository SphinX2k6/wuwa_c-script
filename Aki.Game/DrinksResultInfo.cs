using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003F2 RID: 1010
public class DrinksResultInfo
{
	// Token: 0x04002DBD RID: 11709
	public int RequireId;

	// Token: 0x04002DBE RID: 11710
	[Nullable(1)]
	public List<int> DrinkBase = new List<int>();

	// Token: 0x04002DBF RID: 11711
	public int Ornament;

	// Token: 0x04002DC0 RID: 11712
	[Nullable(2)]
	public IReadOnlyList<int> Batching;
}
