using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200314F RID: 12623
[NullableContext(1)]
[Nullable(0)]
public class SkillBattleContext : ISkillBattleContext
{
	// Token: 0x170025A2 RID: 9634
	// (get) Token: 0x0601B2B2 RID: 111282 RVA: 0x00765311 File Offset: 0x00763511
	// (set) Token: 0x0601B2B3 RID: 111283 RVA: 0x00765319 File Offset: 0x00763519
	public int VisionId { get; set; }

	// Token: 0x170025A3 RID: 9635
	// (get) Token: 0x0601B2B4 RID: 111284 RVA: 0x00765322 File Offset: 0x00763522
	// (set) Token: 0x0601B2B5 RID: 111285 RVA: 0x0076532A File Offset: 0x0076352A
	public List<string> BattleFlags { get; set; } = new List<string>();
}
