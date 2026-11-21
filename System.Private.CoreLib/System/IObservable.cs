using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000154 RID: 340
	[NullableContext(1)]
	public interface IObservable<[Nullable(2)] out T>
	{
		// Token: 0x060016FC RID: 5884
		IDisposable Subscribe(IObserver<T> observer);
	}
}
