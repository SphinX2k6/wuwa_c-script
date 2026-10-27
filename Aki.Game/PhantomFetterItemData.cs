using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200243A RID: 9274
public class PhantomFetterItemData
{
	// Token: 0x04008C36 RID: 35894
	public PhantomFetterGroup? PhantomFetterGroup;

	// Token: 0x04008C37 RID: 35895
	public int RoleId;

	// Token: 0x04008C38 RID: 35896
	[Nullable(1)]
	public List<int> RecommendGroupIds = new List<int>();
}
