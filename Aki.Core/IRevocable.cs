using System;
using System.Runtime.CompilerServices;

// Token: 0x02000058 RID: 88
[NullableContext(1)]
internal interface IRevocable<T> where T : class
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060002B5 RID: 693
	T proxy { get; }

	// Token: 0x060002B6 RID: 694
	void Revoke();
}
