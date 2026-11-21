using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200288D RID: 10381
[NullableContext(1)]
[Nullable(0)]
public class PlotAssetExtra
{
	// Token: 0x0601A4EF RID: 107759 RVA: 0x00824C59 File Offset: 0x00822E59
	public PlotAssetExtra(string plotId)
	{
	}

	// Token: 0x0400E719 RID: 59161
	public readonly string PlotId = plotId;

	// Token: 0x0400E71A RID: 59162
	[Nullable(2)]
	public string VideoPath;

	// Token: 0x0400E71B RID: 59163
	public List<int> QteIds = new List<int>();
}
