using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200069D RID: 1693
	internal interface IAsyncStateMachineBox
	{
		// Token: 0x06007401 RID: 29697
		void MoveNext();

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06007402 RID: 29698
		Action MoveNextAction { get; }

		// Token: 0x06007403 RID: 29699
		IAsyncStateMachine GetStateMachineObject();

		// Token: 0x06007404 RID: 29700
		void ClearStateUponCompletion();
	}
}
