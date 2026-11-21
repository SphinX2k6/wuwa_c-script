using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D58 RID: 7512
[NullableContext(1)]
public interface IRoleDevRootTabData
{
	// Token: 0x17001BB2 RID: 7090
	// (get) Token: 0x06012950 RID: 76112
	// (set) Token: 0x06012951 RID: 76113
	ERoleDevTabType TabIndex { get; set; }

	// Token: 0x17001BB3 RID: 7091
	// (get) Token: 0x06012952 RID: 76114
	// (set) Token: 0x06012953 RID: 76115
	string TabName { get; set; }

	// Token: 0x17001BB4 RID: 7092
	// (get) Token: 0x06012954 RID: 76116
	// (set) Token: 0x06012955 RID: 76117
	bool TabIsUpgrade { get; set; }

	// Token: 0x17001BB5 RID: 7093
	// (get) Token: 0x06012956 RID: 76118
	// (set) Token: 0x06012957 RID: 76119
	bool TabIsFinish { get; set; }
}
