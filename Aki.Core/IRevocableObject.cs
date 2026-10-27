using System;
using System.Runtime.CompilerServices;

// Token: 0x02000057 RID: 87
[NullableContext(1)]
internal interface IRevocableObject<[Nullable(2)] TK, TV> : IRevocable<TV> where TV : class
{
	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600027C RID: 636
	// (set) Token: 0x0600027D RID: 637
	TK Key { get; set; }

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600027E RID: 638
	// (set) Token: 0x0600027F RID: 639
	TV Value { get; set; }
}
