using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006A1 RID: 1697
	public interface ICriticalNotifyCompletion : INotifyCompletion
	{
		// Token: 0x06007409 RID: 29705
		[NullableContext(1)]
		void UnsafeOnCompleted(Action continuation);
	}
}
