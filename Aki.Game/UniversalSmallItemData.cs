using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D61 RID: 7521
[NullableContext(1)]
[Nullable(0)]
public class UniversalSmallItemData<[Nullable(0)] T> : IUniversalSmallItemData<T> where T : Enum
{
	// Token: 0x17001BCF RID: 7119
	// (get) Token: 0x0601298E RID: 76174 RVA: 0x0057BF70 File Offset: 0x0057A170
	// (set) Token: 0x0601298F RID: 76175 RVA: 0x0057BF78 File Offset: 0x0057A178
	public T Type { get; set; }
}
