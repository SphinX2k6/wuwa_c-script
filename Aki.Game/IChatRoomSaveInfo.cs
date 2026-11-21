using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C47 RID: 3143
[NullableContext(1)]
public interface IChatRoomSaveInfo
{
	// Token: 0x17000EA8 RID: 3752
	// (get) Token: 0x0600835C RID: 33628
	// (set) Token: 0x0600835D RID: 33629
	List<IChatRowSaveInfo> ChatRows { get; set; }
}
