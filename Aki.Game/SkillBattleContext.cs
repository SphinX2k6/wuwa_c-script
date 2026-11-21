using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020026BC RID: 9916
[NullableContext(1)]
[Nullable(0)]
public class SkillBattleContext : ISkillBattleContext
{
	// Token: 0x17002793 RID: 10131
	// (get) Token: 0x06018DB7 RID: 101815 RVA: 0x0078CCD5 File Offset: 0x0078AED5
	// (set) Token: 0x06018DB8 RID: 101816 RVA: 0x0078CCDD File Offset: 0x0078AEDD
	public int VisionId { get; set; }

	// Token: 0x17002794 RID: 10132
	// (get) Token: 0x06018DB9 RID: 101817 RVA: 0x0078CCE6 File Offset: 0x0078AEE6
	// (set) Token: 0x06018DBA RID: 101818 RVA: 0x0078CCEE File Offset: 0x0078AEEE
	public List<string> BattleFlags { get; set; } = new List<string>();
}
