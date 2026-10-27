using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E9D RID: 11933
[NullableContext(1)]
public interface IConfigOverrideRule
{
	// Token: 0x1700232D RID: 9005
	// (get) Token: 0x060197CE RID: 104398
	// (set) Token: 0x060197CF RID: 104399
	long OverrideConfigId { get; set; }

	// Token: 0x1700232E RID: 9006
	// (get) Token: 0x060197D0 RID: 104400
	// (set) Token: 0x060197D1 RID: 104401
	EConfigOverrideConditionType ConditionType { get; set; }

	// Token: 0x1700232F RID: 9007
	// (get) Token: 0x060197D2 RID: 104402
	// (set) Token: 0x060197D3 RID: 104403
	string ConditionString { get; set; }
}
