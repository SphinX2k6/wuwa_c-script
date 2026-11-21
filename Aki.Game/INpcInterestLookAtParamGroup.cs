using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200275E RID: 10078
[NullableContext(1)]
public interface INpcInterestLookAtParamGroup
{
	// Token: 0x17002866 RID: 10342
	// (get) Token: 0x060194CE RID: 103630
	// (set) Token: 0x060194CF RID: 103631
	string Key { get; set; }

	// Token: 0x17002867 RID: 10343
	// (get) Token: 0x060194D0 RID: 103632
	// (set) Token: 0x060194D1 RID: 103633
	IList<int> PbDataIds { get; set; }

	// Token: 0x17002868 RID: 10344
	// (get) Token: 0x060194D2 RID: 103634
	// (set) Token: 0x060194D3 RID: 103635
	IList<INpcInterestLookAtParam> Params { get; set; }
}
