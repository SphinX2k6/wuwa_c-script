using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200069C RID: 1692
	[NullableContext(1)]
	public interface IAsyncStateMachine
	{
		// Token: 0x060073FF RID: 29695
		void MoveNext();

		// Token: 0x06007400 RID: 29696
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
