using System;
using System.Runtime.CompilerServices;

// Token: 0x02001411 RID: 5137
[NullableContext(2)]
public interface IPinballRoleViewOpenParam
{
	// Token: 0x17000C5D RID: 3165
	// (get) Token: 0x060090FA RID: 37114
	// (set) Token: 0x060090FB RID: 37115
	int? RoleId { get; set; }

	// Token: 0x17000C5E RID: 3166
	// (get) Token: 0x060090FC RID: 37116
	// (set) Token: 0x060090FD RID: 37117
	int[] FormationRoleIds { get; set; }
}
