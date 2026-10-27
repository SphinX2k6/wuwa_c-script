using System;
using System.Runtime.CompilerServices;

// Token: 0x020027E5 RID: 10213
[NullableContext(1)]
public interface IUniversalSmallItemData<[Nullable(0)] T> where T : Enum
{
	// Token: 0x17001B76 RID: 7030
	// (get) Token: 0x06014F8C RID: 85900
	// (set) Token: 0x06014F8D RID: 85901
	T Type { get; set; }
}
