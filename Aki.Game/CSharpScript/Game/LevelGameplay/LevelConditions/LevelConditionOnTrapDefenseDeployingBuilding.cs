using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D97 RID: 28055
	public class LevelConditionOnTrapDefenseDeployingBuilding : LevelConditionBase
	{
		// Token: 0x060447EA RID: 280554 RVA: 0x010E46F4 File Offset: 0x010E28F4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			return int.TryParse(inConditionInfo.GetLimitParams("MachineId"), out num) && num != 0 && (int)eventArgs[0] == num;
		}
	}
}
