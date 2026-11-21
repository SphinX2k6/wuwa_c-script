using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200369B RID: 13979
	[NullableContext(1)]
	public interface IGameplayEntityExecutionContext
	{
		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x06024479 RID: 148601
		WuWaGoGameModeBase GameMode { get; }

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x0602447A RID: 148602
		HashSet<int> ExecutingPullRodGroups { get; }

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x0602447B RID: 148603
		HashSet<int> PendingBowTrapPbDataIds { get; }

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x0602447C RID: 148604
		HashSet<int> PendingMovableFloorPbDataIds { get; }
	}
}
