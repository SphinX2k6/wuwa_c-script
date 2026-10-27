using System;
using System.Runtime.CompilerServices;

// Token: 0x02003116 RID: 12566
[NullableContext(2)]
public interface ISwitchState : IActionParamMap
{
	// Token: 0x1700255F RID: 9567
	// (get) Token: 0x0601B029 RID: 110633
	// (set) Token: 0x0601B02A RID: 110634
	string TargetStateName { get; set; }

	// Token: 0x17002560 RID: 9568
	// (get) Token: 0x0601B02B RID: 110635
	// (set) Token: 0x0601B02C RID: 110636
	bool? IsNoTransition { get; set; }

	// Token: 0x17002561 RID: 9569
	// (get) Token: 0x0601B02D RID: 110637
	// (set) Token: 0x0601B02E RID: 110638
	string Context { get; set; }
}
