using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D60 RID: 7520
[NullableContext(1)]
public interface IUniversalSmallItemData<[Nullable(0)] T> where T : Enum
{
	// Token: 0x17001BCE RID: 7118
	// (get) Token: 0x0601298C RID: 76172
	// (set) Token: 0x0601298D RID: 76173
	T Type { get; set; }
}
