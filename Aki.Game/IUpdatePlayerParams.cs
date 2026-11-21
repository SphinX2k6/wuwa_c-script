using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001ED1 RID: 7889
[NullableContext(1)]
public interface IUpdatePlayerParams
{
	// Token: 0x17001DBD RID: 7613
	// (get) Token: 0x060137D8 RID: 79832
	// (set) Token: 0x060137D9 RID: 79833
	int PlayerId { get; set; }

	// Token: 0x17001DBE RID: 7614
	// (get) Token: 0x060137DA RID: 79834
	// (set) Token: 0x060137DB RID: 79835
	ETeamGroupType CurrentGroupType { get; set; }

	// Token: 0x17001DBF RID: 7615
	// (get) Token: 0x060137DC RID: 79836
	// (set) Token: 0x060137DD RID: 79837
	IList<IUpdateGroupParams> Groups { get; set; }
}
