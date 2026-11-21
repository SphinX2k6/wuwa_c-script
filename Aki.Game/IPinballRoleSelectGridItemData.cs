using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020008C6 RID: 2246
[NullableContext(1)]
public interface IPinballRoleSelectGridItemData
{
	// Token: 0x17000C7F RID: 3199
	// (get) Token: 0x06006493 RID: 25747
	// (set) Token: 0x06006494 RID: 25748
	PinballRoleDataBase RoleData { get; set; }

	// Token: 0x17000C80 RID: 3200
	// (get) Token: 0x06006495 RID: 25749
	// (set) Token: 0x06006496 RID: 25750
	IPinballItemDataRole ItemData { get; set; }

	// Token: 0x17000C81 RID: 3201
	// (get) Token: 0x06006497 RID: 25751
	// (set) Token: 0x06006498 RID: 25752
	List<int> ClassIdList { get; set; }

	// Token: 0x17000C82 RID: 3202
	// (get) Token: 0x06006499 RID: 25753
	// (set) Token: 0x0600649A RID: 25754
	bool IsSelected { get; set; }

	// Token: 0x17000C83 RID: 3203
	// (get) Token: 0x0600649B RID: 25755
	// (set) Token: 0x0600649C RID: 25756
	int FormationIndex { get; set; }
}
