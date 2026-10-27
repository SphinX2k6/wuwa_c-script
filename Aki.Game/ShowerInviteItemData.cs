using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A02 RID: 10754
[NullableContext(1)]
[Nullable(0)]
public class ShowerInviteItemData : IShowerInviteItemData
{
	// Token: 0x17001DCC RID: 7628
	// (get) Token: 0x0601650B RID: 91403 RVA: 0x005A5A86 File Offset: 0x005A3C86
	// (set) Token: 0x0601650C RID: 91404 RVA: 0x005A5A8E File Offset: 0x005A3C8E
	public RoleInstance RoleInstance { get; set; }

	// Token: 0x17001DCD RID: 7629
	// (get) Token: 0x0601650D RID: 91405 RVA: 0x005A5A97 File Offset: 0x005A3C97
	// (set) Token: 0x0601650E RID: 91406 RVA: 0x005A5A9F File Offset: 0x005A3C9F
	public bool IsInFormation { get; set; }
}
