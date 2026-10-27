using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200178F RID: 6031
[NullableContext(1)]
[Nullable(0)]
public class ChatRoomSaveInfo : IChatRoomSaveInfo
{
	// Token: 0x17000E86 RID: 3718
	// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x0027A8F9 File Offset: 0x00278AF9
	// (set) Token: 0x0600AF77 RID: 44919 RVA: 0x0027A901 File Offset: 0x00278B01
	public List<IChatRowSaveInfo> ChatRows { get; set; }
}
