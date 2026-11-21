using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C17 RID: 7191
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoSkillViewParam : IRacingBetsDangoSkillViewParam
{
	// Token: 0x17001B2E RID: 6958
	// (get) Token: 0x06011DC1 RID: 73153 RVA: 0x0054053D File Offset: 0x0053E73D
	// (set) Token: 0x06011DC2 RID: 73154 RVA: 0x00540545 File Offset: 0x0053E745
	public List<RacingBetsDungeonDangoInfo> DangoList { get; set; }

	// Token: 0x17001B2F RID: 6959
	// (get) Token: 0x06011DC3 RID: 73155 RVA: 0x0054054E File Offset: 0x0053E74E
	// (set) Token: 0x06011DC4 RID: 73156 RVA: 0x00540556 File Offset: 0x0053E756
	[Nullable(2)]
	public Action CloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
