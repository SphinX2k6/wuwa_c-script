using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002456 RID: 9302
public class PhantomSortMetric
{
	// Token: 0x04008C8B RID: 35979
	public bool HasRecommendMainProp;

	// Token: 0x04008C8C RID: 35980
	public bool HasRecommendSubProp;

	// Token: 0x04008C8D RID: 35981
	public int MainPropUsage;

	// Token: 0x04008C8E RID: 35982
	public int SubPropUsage;

	// Token: 0x04008C8F RID: 35983
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
