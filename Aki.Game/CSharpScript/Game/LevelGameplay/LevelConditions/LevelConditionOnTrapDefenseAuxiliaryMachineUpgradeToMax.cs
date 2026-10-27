using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D91 RID: 28049
	public class LevelConditionOnTrapDefenseAuxiliaryMachineUpgradeToMax : LevelConditionBase
	{
		// Token: 0x060447DE RID: 280542 RVA: 0x010E4540 File Offset: 0x010E2740
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = eventArgs[0] as TrapDefenseBuildingDevelopItemData;
			return trapDefenseBuildingDevelopItemData != null && (trapDefenseBuildingDevelopItemData.GetHasBranch() && trapDefenseBuildingDevelopItemData.GetIsUnlock()) && !trapDefenseBuildingDevelopItemData.IsBuilding;
		}
	}
}
