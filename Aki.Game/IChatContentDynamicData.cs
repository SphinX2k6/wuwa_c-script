using System;
using System.Runtime.CompilerServices;

// Token: 0x02001794 RID: 6036
[NullableContext(1)]
public interface IChatContentDynamicData
{
	// Token: 0x17000EA7 RID: 3751
	// (get) Token: 0x0600AFBB RID: 44987
	// (set) Token: 0x0600AFBC RID: 44988
	ChatContentData ChatContentData { get; set; }

	// Token: 0x17000EA8 RID: 3752
	// (get) Token: 0x0600AFBD RID: 44989
	// (set) Token: 0x0600AFBE RID: 44990
	EChatContentType Type { get; set; }
}
