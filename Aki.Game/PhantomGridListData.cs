using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001949 RID: 6473
[NullableContext(1)]
[Nullable(0)]
public class PhantomGridListData : IPhantomGridListData
{
	// Token: 0x17001894 RID: 6292
	// (get) Token: 0x0600FFCE RID: 65486 RVA: 0x004AAD92 File Offset: 0x004A8F92
	// (set) Token: 0x0600FFCF RID: 65487 RVA: 0x004AAD9A File Offset: 0x004A8F9A
	public EGridTitleType TitleType { get; set; }

	// Token: 0x17001895 RID: 6293
	// (get) Token: 0x0600FFD0 RID: 65488 RVA: 0x004AADA3 File Offset: 0x004A8FA3
	// (set) Token: 0x0600FFD1 RID: 65489 RVA: 0x004AADAB File Offset: 0x004A8FAB
	public List<int> MonsterIds { get; set; } = new List<int>();
}
