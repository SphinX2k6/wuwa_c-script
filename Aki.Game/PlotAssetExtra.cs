using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200331B RID: 13083
[NullableContext(1)]
[Nullable(0)]
public class PlotAssetExtra
{
	// Token: 0x0601C7F6 RID: 116726 RVA: 0x007FE6ED File Offset: 0x007FC8ED
	public PlotAssetExtra(string plotId)
	{
	}

	// Token: 0x0400E268 RID: 57960
	public readonly string PlotId = plotId;

	// Token: 0x0400E269 RID: 57961
	[Nullable(2)]
	public string VideoPath;

	// Token: 0x0400E26A RID: 57962
	public List<int> QteIds = new List<int>();
}
