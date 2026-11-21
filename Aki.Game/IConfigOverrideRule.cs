using System;
using System.Runtime.CompilerServices;

// Token: 0x020023F0 RID: 9200
[NullableContext(1)]
public interface IConfigOverrideRule
{
	// Token: 0x170023B8 RID: 9144
	// (get) Token: 0x060170A4 RID: 94372
	// (set) Token: 0x060170A5 RID: 94373
	long OverrideConfigId { get; set; }

	// Token: 0x170023B9 RID: 9145
	// (get) Token: 0x060170A6 RID: 94374
	// (set) Token: 0x060170A7 RID: 94375
	EConfigOverrideConditionType ConditionType { get; set; }

	// Token: 0x170023BA RID: 9146
	// (get) Token: 0x060170A8 RID: 94376
	// (set) Token: 0x060170A9 RID: 94377
	string ConditionString { get; set; }
}
