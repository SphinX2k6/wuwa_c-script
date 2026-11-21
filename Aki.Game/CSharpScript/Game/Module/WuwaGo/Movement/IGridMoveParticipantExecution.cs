using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200365E RID: 13918
	[NullableContext(1)]
	internal interface IGridMoveParticipantExecution
	{
		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x0602419D RID: 147869
		IWuWaGoGridMoveParticipant Participant { get; }

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x0602419E RID: 147870
		IWuWaGoGridRelocationContext Context { get; }
	}
}
