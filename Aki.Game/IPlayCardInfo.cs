using System;
using System.Runtime.CompilerServices;

// Token: 0x02001059 RID: 4185
[NullableContext(1)]
public interface IPlayCardInfo
{
	// Token: 0x170008A9 RID: 2217
	// (get) Token: 0x06006B32 RID: 27442
	// (set) Token: 0x06006B33 RID: 27443
	int Value { get; set; }

	// Token: 0x170008AA RID: 2218
	// (get) Token: 0x06006B34 RID: 27444
	// (set) Token: 0x06006B35 RID: 27445
	int[] CardIdList { get; set; }
}
