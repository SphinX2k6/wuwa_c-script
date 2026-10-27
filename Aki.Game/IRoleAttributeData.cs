using System;
using System.Runtime.CompilerServices;

// Token: 0x020027C2 RID: 10178
[NullableContext(1)]
public interface IRoleAttributeData
{
	// Token: 0x17001B31 RID: 6961
	// (get) Token: 0x06014EF1 RID: 85745
	// (set) Token: 0x06014EF2 RID: 85746
	string Name { get; set; }

	// Token: 0x17001B32 RID: 6962
	// (get) Token: 0x06014EF3 RID: 85747
	// (set) Token: 0x06014EF4 RID: 85748
	int Level { get; set; }

	// Token: 0x17001B33 RID: 6963
	// (get) Token: 0x06014EF5 RID: 85749
	// (set) Token: 0x06014EF6 RID: 85750
	int BreakLevel { get; set; }

	// Token: 0x17001B34 RID: 6964
	// (get) Token: 0x06014EF7 RID: 85751
	// (set) Token: 0x06014EF8 RID: 85752
	int Exp { get; set; }
}
