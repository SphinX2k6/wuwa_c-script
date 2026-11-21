using System;
using System.Runtime.CompilerServices;

// Token: 0x020008DE RID: 2270
[NullableContext(2)]
[Nullable(0)]
public class PinballRoleViewOpenParam : IPinballRoleViewOpenParam
{
	// Token: 0x17000CD0 RID: 3280
	// (get) Token: 0x06006542 RID: 25922 RVA: 0x001FBB62 File Offset: 0x001F9D62
	// (set) Token: 0x06006543 RID: 25923 RVA: 0x001FBB6A File Offset: 0x001F9D6A
	public int? RoleId { get; set; }

	// Token: 0x17000CD1 RID: 3281
	// (get) Token: 0x06006544 RID: 25924 RVA: 0x001FBB73 File Offset: 0x001F9D73
	// (set) Token: 0x06006545 RID: 25925 RVA: 0x001FBB7B File Offset: 0x001F9D7B
	public int[] FormationRoleIds { get; set; }
}
