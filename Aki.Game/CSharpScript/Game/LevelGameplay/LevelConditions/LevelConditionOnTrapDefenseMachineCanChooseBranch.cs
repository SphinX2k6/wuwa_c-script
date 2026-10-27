using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D92 RID: 28050
	public class LevelConditionOnTrapDefenseMachineCanChooseBranch : LevelConditionBase
	{
		// Token: 0x060447E0 RID: 280544 RVA: 0x010E4580 File Offset: 0x010E2780
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = eventArgs[0] as TrapDefenseBuildingDevelopItemData;
			return trapDefenseBuildingDevelopItemData != null && trapDefenseBuildingDevelopItemData.GetHasBranch() && trapDefenseBuildingDevelopItemData.GetIsUnlock();
		}
	}
}
