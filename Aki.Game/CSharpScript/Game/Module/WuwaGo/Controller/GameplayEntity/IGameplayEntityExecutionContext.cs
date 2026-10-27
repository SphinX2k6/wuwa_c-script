using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200476A RID: 18282
	[NullableContext(1)]
	public interface IGameplayEntityExecutionContext
	{
		// Token: 0x1700775E RID: 30558
		// (get) Token: 0x0602FCAF RID: 195759
		WuWaGoGameModeBase GameMode { get; }

		// Token: 0x1700775F RID: 30559
		// (get) Token: 0x0602FCB0 RID: 195760
		HashSet<int> ExecutingPullRodGroups { get; }

		// Token: 0x17007760 RID: 30560
		// (get) Token: 0x0602FCB1 RID: 195761
		HashSet<int> PendingBowTrapPbDataIds { get; }

		// Token: 0x17007761 RID: 30561
		// (get) Token: 0x0602FCB2 RID: 195762
		HashSet<int> PendingMovableFloorPbDataIds { get; }
	}
}
