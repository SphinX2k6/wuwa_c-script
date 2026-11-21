using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F10 RID: 24336
	public class LevelConditionOnTrapDefenseAuxiliaryMachineUpgradeToMax : LevelConditionBase
	{
		// Token: 0x0603A942 RID: 239938 RVA: 0x0108E768 File Offset: 0x0108C968
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = eventArgs[0] as TrapDefenseBuildingDevelopItemData;
			return trapDefenseBuildingDevelopItemData != null && (trapDefenseBuildingDevelopItemData.GetHasBranch() && trapDefenseBuildingDevelopItemData.GetIsUnlock()) && !trapDefenseBuildingDevelopItemData.IsBuilding;
		}
	}
}
