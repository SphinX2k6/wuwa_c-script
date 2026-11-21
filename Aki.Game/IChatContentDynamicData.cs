using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C4D RID: 3149
[NullableContext(1)]
public interface IChatContentDynamicData
{
	// Token: 0x17000ECA RID: 3786
	// (get) Token: 0x060083A3 RID: 33699
	// (set) Token: 0x060083A4 RID: 33700
	ChatContentData ChatContentData { get; set; }

	// Token: 0x17000ECB RID: 3787
	// (get) Token: 0x060083A5 RID: 33701
	// (set) Token: 0x060083A6 RID: 33702
	EChatContentType Type { get; set; }
}
