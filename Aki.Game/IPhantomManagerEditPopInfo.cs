using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200241D RID: 9245
[NullableContext(1)]
public interface IPhantomManagerEditPopInfo
{
	// Token: 0x170017FE RID: 6142
	// (get) Token: 0x06012813 RID: 75795
	// (set) Token: 0x06012814 RID: 75796
	int FetterId { get; set; }

	// Token: 0x170017FF RID: 6143
	// (get) Token: 0x06012815 RID: 75797
	// (set) Token: 0x06012816 RID: 75798
	int Count { get; set; }

	// Token: 0x17001800 RID: 6144
	// (get) Token: 0x06012817 RID: 75799
	// (set) Token: 0x06012818 RID: 75800
	List<IPhantomManagerConfigNewSettingInfo> DataList { get; set; }

	// Token: 0x17001801 RID: 6145
	// (get) Token: 0x06012819 RID: 75801
	// (set) Token: 0x0601281A RID: 75802
	[Nullable(2)]
	Action CloseCb { [NullableContext(2)] get; [NullableContext(2)] set; }
}
