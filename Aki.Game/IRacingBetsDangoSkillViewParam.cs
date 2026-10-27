using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200272B RID: 10027
[NullableContext(1)]
public interface IRacingBetsDangoSkillViewParam
{
	// Token: 0x17001AF4 RID: 6900
	// (get) Token: 0x060148DB RID: 84187
	// (set) Token: 0x060148DC RID: 84188
	List<RacingBetsDungeonDangoInfo> DangoList { get; set; }

	// Token: 0x17001AF5 RID: 6901
	// (get) Token: 0x060148DD RID: 84189
	// (set) Token: 0x060148DE RID: 84190
	[Nullable(2)]
	Action CloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
