using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F16 RID: 24342
	public class LevelConditionOnTrapDefenseDeployingBuilding : LevelConditionBase
	{
		// Token: 0x0603A94E RID: 239950 RVA: 0x0108E91C File Offset: 0x0108CB1C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			return int.TryParse(inConditionInfo.GetLimitParams("MachineId"), out num) && num != 0 && (int)eventArgs[0] == num;
		}
	}
}
