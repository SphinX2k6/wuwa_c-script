using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000155 RID: 341
	[NullableContext(1)]
	public interface IObserver<[Nullable(2)] in T>
	{
		// Token: 0x060016FD RID: 5885
		void OnNext(T value);

		// Token: 0x060016FE RID: 5886
		void OnError(Exception error);

		// Token: 0x060016FF RID: 5887
		void OnCompleted();
	}
}
