using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006A0 RID: 1696
	[NullableContext(1)]
	public interface INotifyCompletion
	{
		// Token: 0x06007408 RID: 29704
		void OnCompleted(Action continuation);
	}
}
