using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C16 RID: 7190
[NullableContext(1)]
public interface IRacingBetsDangoSkillViewParam
{
	// Token: 0x17001B2C RID: 6956
	// (get) Token: 0x06011DBD RID: 73149
	// (set) Token: 0x06011DBE RID: 73150
	List<RacingBetsDungeonDangoInfo> DangoList { get; set; }

	// Token: 0x17001B2D RID: 6957
	// (get) Token: 0x06011DBF RID: 73151
	// (set) Token: 0x06011DC0 RID: 73152
	[Nullable(2)]
	Action CloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
