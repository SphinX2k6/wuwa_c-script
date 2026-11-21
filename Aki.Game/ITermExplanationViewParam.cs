using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200211E RID: 8478
[NullableContext(1)]
public interface ITermExplanationViewParam
{
	// Token: 0x17001F86 RID: 8070
	// (get) Token: 0x06014C69 RID: 85097
	// (set) Token: 0x06014C6A RID: 85098
	List<string> HyperLinkList { get; set; }

	// Token: 0x17001F87 RID: 8071
	// (get) Token: 0x06014C6B RID: 85099
	// (set) Token: 0x06014C6C RID: 85100
	[Nullable(2)]
	string FocusedHyperLink { [NullableContext(2)] get; [NullableContext(2)] set; }
}
