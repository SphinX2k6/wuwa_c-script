using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200472D RID: 18221
	[NullableContext(1)]
	internal interface IGridMoveParticipantExecution
	{
		// Token: 0x170076F7 RID: 30455
		// (get) Token: 0x0602F9D3 RID: 195027
		IWuWaGoGridMoveParticipant Participant { get; }

		// Token: 0x170076F8 RID: 30456
		// (get) Token: 0x0602F9D4 RID: 195028
		IWuWaGoGridRelocationContext Context { get; }
	}
}
