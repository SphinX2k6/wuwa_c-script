using System;
using System.Runtime.CompilerServices;

// Token: 0x02000056 RID: 86
[NullableContext(1)]
internal interface IRevocable<T> where T : class
{
	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600027A RID: 634
	T proxy { get; }

	// Token: 0x0600027B RID: 635
	void Revoke();
}
