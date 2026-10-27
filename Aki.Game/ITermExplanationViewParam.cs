using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002BA2 RID: 11170
[NullableContext(1)]
public interface ITermExplanationViewParam
{
	// Token: 0x17001F2E RID: 7982
	// (get) Token: 0x06017238 RID: 94776
	// (set) Token: 0x06017239 RID: 94777
	List<string> HyperLinkList { get; set; }

	// Token: 0x17001F2F RID: 7983
	// (get) Token: 0x0601723A RID: 94778
	// (set) Token: 0x0601723B RID: 94779
	[Nullable(2)]
	string FocusedHyperLink { [NullableContext(2)] get; [NullableContext(2)] set; }
}
