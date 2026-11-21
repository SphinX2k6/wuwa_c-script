using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D5C RID: 7516
[NullableContext(1)]
public interface IMaterialGroup
{
	// Token: 0x17001BBE RID: 7102
	// (get) Token: 0x0601296A RID: 76138
	// (set) Token: 0x0601296B RID: 76139
	int Type { get; set; }

	// Token: 0x17001BBF RID: 7103
	// (get) Token: 0x0601296C RID: 76140
	// (set) Token: 0x0601296D RID: 76141
	List<IItemMaterial> Materials { get; set; }
}
