using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BF6 RID: 7158
public class FormationViewSwitchCache
{
	// Token: 0x040061B4 RID: 25012
	public int EditFormationId;

	// Token: 0x040061B5 RID: 25013
	public int GoBattleFormationId;

	// Token: 0x040061B6 RID: 25014
	[Nullable(1)]
	public Dictionary<int, int[]> EditingSnapshot = new Dictionary<int, int[]>();

	// Token: 0x040061B7 RID: 25015
	public long SwitchStartTimeMs;
}
