using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F3D RID: 3901
public class DrinksResultInfo
{
	// Token: 0x04002D24 RID: 11556
	public int RequireId;

	// Token: 0x04002D25 RID: 11557
	[Nullable(1)]
	public List<int> DrinkBase = new List<int>();

	// Token: 0x04002D26 RID: 11558
	public int Ornament;

	// Token: 0x04002D27 RID: 11559
	[Nullable(2)]
	public IReadOnlyList<int> Batching;
}
