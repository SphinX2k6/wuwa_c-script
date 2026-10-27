using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200272C RID: 10028
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoSkillViewParam : IRacingBetsDangoSkillViewParam
{
	// Token: 0x17001AF6 RID: 6902
	// (get) Token: 0x060148DF RID: 84191 RVA: 0x00531825 File Offset: 0x0052FA25
	// (set) Token: 0x060148E0 RID: 84192 RVA: 0x0053182D File Offset: 0x0052FA2D
	public List<RacingBetsDungeonDangoInfo> DangoList { get; set; }

	// Token: 0x17001AF7 RID: 6903
	// (get) Token: 0x060148E1 RID: 84193 RVA: 0x00531836 File Offset: 0x0052FA36
	// (set) Token: 0x060148E2 RID: 84194 RVA: 0x0053183E File Offset: 0x0052FA3E
	[Nullable(2)]
	public Action CloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
