using System;
using System.Runtime.CompilerServices;

// Token: 0x02001795 RID: 6037
[NullableContext(1)]
[Nullable(0)]
public class ChatContentDynamicData : IChatContentDynamicData
{
	// Token: 0x17000EA9 RID: 3753
	// (get) Token: 0x0600AFBF RID: 44991 RVA: 0x0027AA32 File Offset: 0x00278C32
	// (set) Token: 0x0600AFC0 RID: 44992 RVA: 0x0027AA3A File Offset: 0x00278C3A
	public ChatContentData ChatContentData { get; set; }

	// Token: 0x17000EAA RID: 3754
	// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x0027AA43 File Offset: 0x00278C43
	// (set) Token: 0x0600AFC2 RID: 44994 RVA: 0x0027AA4B File Offset: 0x00278C4B
	public EChatContentType Type { get; set; }
}
