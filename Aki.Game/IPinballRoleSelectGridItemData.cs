using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001412 RID: 5138
[NullableContext(1)]
public interface IPinballRoleSelectGridItemData
{
	// Token: 0x17000C5F RID: 3167
	// (get) Token: 0x060090FE RID: 37118
	// (set) Token: 0x060090FF RID: 37119
	PinballRoleDataBase RoleData { get; set; }

	// Token: 0x17000C60 RID: 3168
	// (get) Token: 0x06009100 RID: 37120
	// (set) Token: 0x06009101 RID: 37121
	IPinballItemDataRole ItemData { get; set; }

	// Token: 0x17000C61 RID: 3169
	// (get) Token: 0x06009102 RID: 37122
	// (set) Token: 0x06009103 RID: 37123
	List<int> ClassIdList { get; set; }

	// Token: 0x17000C62 RID: 3170
	// (get) Token: 0x06009104 RID: 37124
	// (set) Token: 0x06009105 RID: 37125
	bool IsSelected { get; set; }

	// Token: 0x17000C63 RID: 3171
	// (get) Token: 0x06009106 RID: 37126
	// (set) Token: 0x06009107 RID: 37127
	int FormationIndex { get; set; }
}
