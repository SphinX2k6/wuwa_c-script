using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200191F RID: 6431
public class PhantomFetterItemData
{
	// Token: 0x04008D7D RID: 36221
	public PhantomFetterGroup? PhantomFetterGroup;

	// Token: 0x04008D7E RID: 36222
	public int RoleId;

	// Token: 0x04008D7F RID: 36223
	[Nullable(1)]
	public List<int> RecommendGroupIds = new List<int>();
}
