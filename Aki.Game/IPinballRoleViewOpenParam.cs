using System;
using System.Runtime.CompilerServices;

// Token: 0x020008C5 RID: 2245
[NullableContext(2)]
public interface IPinballRoleViewOpenParam
{
	// Token: 0x17000C7D RID: 3197
	// (get) Token: 0x0600648F RID: 25743
	// (set) Token: 0x06006490 RID: 25744
	int? RoleId { get; set; }

	// Token: 0x17000C7E RID: 3198
	// (get) Token: 0x06006491 RID: 25745
	// (set) Token: 0x06006492 RID: 25746
	int[] FormationRoleIds { get; set; }
}
