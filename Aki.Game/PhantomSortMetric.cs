using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200193B RID: 6459
public class PhantomSortMetric
{
	// Token: 0x04008DD2 RID: 36306
	public bool HasRecommendMainProp;

	// Token: 0x04008DD3 RID: 36307
	public bool HasRecommendSubProp;

	// Token: 0x04008DD4 RID: 36308
	public int MainPropUsage;

	// Token: 0x04008DD5 RID: 36309
	public int SubPropUsage;

	// Token: 0x04008DD6 RID: 36310
	[TupleElementNames(new string[]
	{
		"AddType",
		"PropId"
	})]
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public List<ValueTuple<int, int>> SubPropConfigs;
}
