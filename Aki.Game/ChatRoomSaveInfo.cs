using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000C48 RID: 3144
[NullableContext(1)]
[Nullable(0)]
public class ChatRoomSaveInfo : IChatRoomSaveInfo
{
	// Token: 0x17000EA9 RID: 3753
	// (get) Token: 0x0600835E RID: 33630 RVA: 0x00284D7D File Offset: 0x00282F7D
	// (set) Token: 0x0600835F RID: 33631 RVA: 0x00284D85 File Offset: 0x00282F85
	public List<IChatRowSaveInfo> ChatRows { get; set; }
}
