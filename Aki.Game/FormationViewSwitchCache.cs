using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010B5 RID: 4277
public class FormationViewSwitchCache
{
	// Token: 0x04006286 RID: 25222
	public int EditFormationId;

	// Token: 0x04006287 RID: 25223
	public int GoBattleFormationId;

	// Token: 0x04006288 RID: 25224
	[Nullable(1)]
	public Dictionary<int, int[]> EditingSnapshot = new Dictionary<int, int[]>();

	// Token: 0x04006289 RID: 25225
	public long SwitchStartTimeMs;
}
