using System;
using System.Runtime.CompilerServices;

// Token: 0x02002671 RID: 9841
[NullableContext(2)]
public interface ISwitchState : IActionParamMap
{
	// Token: 0x1700270A RID: 9994
	// (get) Token: 0x06018A84 RID: 100996
	// (set) Token: 0x06018A85 RID: 100997
	string TargetStateName { get; set; }

	// Token: 0x1700270B RID: 9995
	// (get) Token: 0x06018A86 RID: 100998
	// (set) Token: 0x06018A87 RID: 100999
	bool? IsNoTransition { get; set; }

	// Token: 0x1700270C RID: 9996
	// (get) Token: 0x06018A88 RID: 101000
	// (set) Token: 0x06018A89 RID: 101001
	string Context { get; set; }
}
