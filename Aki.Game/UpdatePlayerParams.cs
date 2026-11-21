using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001ED2 RID: 7890
[NullableContext(1)]
[Nullable(0)]
public class UpdatePlayerParams : IUpdatePlayerParams
{
	// Token: 0x17001DC0 RID: 7616
	// (get) Token: 0x060137DE RID: 79838 RVA: 0x005AEFC2 File Offset: 0x005AD1C2
	// (set) Token: 0x060137DF RID: 79839 RVA: 0x005AEFCA File Offset: 0x005AD1CA
	public int PlayerId { get; set; }

	// Token: 0x17001DC1 RID: 7617
	// (get) Token: 0x060137E0 RID: 79840 RVA: 0x005AEFD3 File Offset: 0x005AD1D3
	// (set) Token: 0x060137E1 RID: 79841 RVA: 0x005AEFDB File Offset: 0x005AD1DB
	public ETeamGroupType CurrentGroupType { get; set; }

	// Token: 0x17001DC2 RID: 7618
	// (get) Token: 0x060137E2 RID: 79842 RVA: 0x005AEFE4 File Offset: 0x005AD1E4
	// (set) Token: 0x060137E3 RID: 79843 RVA: 0x005AEFEC File Offset: 0x005AD1EC
	public IList<IUpdateGroupParams> Groups { get; set; }
}
