using System;
using System.Runtime.CompilerServices;

// Token: 0x020027E6 RID: 10214
[NullableContext(1)]
[Nullable(0)]
public class UniversalSmallItemData<[Nullable(0)] T> : IUniversalSmallItemData<T> where T : Enum
{
	// Token: 0x17001B77 RID: 7031
	// (get) Token: 0x06014F8E RID: 85902 RVA: 0x00551200 File Offset: 0x0054F400
	// (set) Token: 0x06014F8F RID: 85903 RVA: 0x00551208 File Offset: 0x0054F408
	public T Type { get; set; }
}
