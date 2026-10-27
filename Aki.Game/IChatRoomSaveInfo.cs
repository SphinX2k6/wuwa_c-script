using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200178E RID: 6030
[NullableContext(1)]
public interface IChatRoomSaveInfo
{
	// Token: 0x17000E85 RID: 3717
	// (get) Token: 0x0600AF74 RID: 44916
	// (set) Token: 0x0600AF75 RID: 44917
	List<IChatRowSaveInfo> ChatRows { get; set; }
}
