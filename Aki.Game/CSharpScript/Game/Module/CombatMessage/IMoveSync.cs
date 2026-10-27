using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02005BAD RID: 23469
	[NullableContext(1)]
	public interface IMoveSync
	{
		// Token: 0x17008CF5 RID: 36085
		// (get) Token: 0x0603B5A0 RID: 243104
		Entity Entity { get; }

		// Token: 0x17008CF6 RID: 36086
		// (get) Token: 0x0603B5A1 RID: 243105
		List<MoveReplaySample> PendingMoveInfos { get; }

		// Token: 0x0603B5A2 RID: 243106
		[NullableContext(2)]
		MovingEntityData CollectPendingMoveInfos();
	}
}
