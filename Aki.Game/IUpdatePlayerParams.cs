using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002956 RID: 10582
[NullableContext(1)]
public interface IUpdatePlayerParams
{
	// Token: 0x17001D64 RID: 7524
	// (get) Token: 0x06015DD4 RID: 89556
	// (set) Token: 0x06015DD5 RID: 89557
	int PlayerId { get; set; }

	// Token: 0x17001D65 RID: 7525
	// (get) Token: 0x06015DD6 RID: 89558
	// (set) Token: 0x06015DD7 RID: 89559
	ETeamGroupType CurrentGroupType { get; set; }

	// Token: 0x17001D66 RID: 7526
	// (get) Token: 0x06015DD8 RID: 89560
	// (set) Token: 0x06015DD9 RID: 89561
	IList<IUpdateGroupParams> Groups { get; set; }
}
