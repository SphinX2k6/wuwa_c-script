using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F11 RID: 24337
	public class LevelConditionOnTrapDefenseMachineCanChooseBranch : LevelConditionBase
	{
		// Token: 0x0603A944 RID: 239940 RVA: 0x0108E7A8 File Offset: 0x0108C9A8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = eventArgs[0] as TrapDefenseBuildingDevelopItemData;
			return trapDefenseBuildingDevelopItemData != null && trapDefenseBuildingDevelopItemData.GetHasBranch() && trapDefenseBuildingDevelopItemData.GetIsUnlock();
		}
	}
}
