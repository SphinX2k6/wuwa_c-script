using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B8D RID: 19341
	[NullableContext(1)]
	public interface IMoveSync
	{
		// Token: 0x170060C7 RID: 24775
		// (get) Token: 0x060304ED RID: 197869
		Entity Entity { get; }

		// Token: 0x170060C8 RID: 24776
		// (get) Token: 0x060304EE RID: 197870
		List<MoveReplaySample> PendingMoveInfos { get; }

		// Token: 0x060304EF RID: 197871
		[NullableContext(2)]
		MovingEntityData CollectPendingMoveInfos();
	}
}
