using System;
using System.Runtime.CompilerServices;

// Token: 0x02003117 RID: 12567
[NullableContext(2)]
[Nullable(0)]
public class SwitchState : ISwitchState, IActionParamMap
{
	// Token: 0x17002562 RID: 9570
	// (get) Token: 0x0601B02F RID: 110639 RVA: 0x00754E5B File Offset: 0x0075305B
	// (set) Token: 0x0601B030 RID: 110640 RVA: 0x00754E63 File Offset: 0x00753063
	public string TargetStateName { get; set; }

	// Token: 0x17002563 RID: 9571
	// (get) Token: 0x0601B031 RID: 110641 RVA: 0x00754E6C File Offset: 0x0075306C
	// (set) Token: 0x0601B032 RID: 110642 RVA: 0x00754E74 File Offset: 0x00753074
	public bool? IsNoTransition { get; set; }

	// Token: 0x17002564 RID: 9572
	// (get) Token: 0x0601B033 RID: 110643 RVA: 0x00754E7D File Offset: 0x0075307D
	// (set) Token: 0x0601B034 RID: 110644 RVA: 0x00754E85 File Offset: 0x00753085
	public string Context { get; set; }
}
