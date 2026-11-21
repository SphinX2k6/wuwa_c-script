using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F7D RID: 8061
[NullableContext(1)]
[Nullable(0)]
public class ShowerInviteItemData : IShowerInviteItemData
{
	// Token: 0x17001E25 RID: 7717
	// (get) Token: 0x06013F12 RID: 81682 RVA: 0x005D0A5E File Offset: 0x005CEC5E
	// (set) Token: 0x06013F13 RID: 81683 RVA: 0x005D0A66 File Offset: 0x005CEC66
	public RoleInstance RoleInstance { get; set; }

	// Token: 0x17001E26 RID: 7718
	// (get) Token: 0x06013F14 RID: 81684 RVA: 0x005D0A6F File Offset: 0x005CEC6F
	// (set) Token: 0x06013F15 RID: 81685 RVA: 0x005D0A77 File Offset: 0x005CEC77
	public bool IsInFormation { get; set; }
}
