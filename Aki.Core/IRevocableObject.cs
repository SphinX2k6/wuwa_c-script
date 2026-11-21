using System;
using System.Runtime.CompilerServices;

// Token: 0x02000059 RID: 89
[NullableContext(1)]
internal interface IRevocableObject<[Nullable(2)] TK, TV> : IRevocable<TV> where TV : class
{
	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060002B7 RID: 695
	// (set) Token: 0x060002B8 RID: 696
	TK Key { get; set; }

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060002B9 RID: 697
	// (set) Token: 0x060002BA RID: 698
	TV Value { get; set; }
}
