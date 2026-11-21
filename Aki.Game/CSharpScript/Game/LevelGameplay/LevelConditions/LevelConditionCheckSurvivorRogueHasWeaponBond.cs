using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F07 RID: 24327
	public class LevelConditionCheckSurvivorRogueHasWeaponBond : LevelConditionBase
	{
		// Token: 0x0603A930 RID: 239920 RVA: 0x0108E2E8 File Offset: 0x0108C4E8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			List<ISurvivorsWeaponGridData> weaponGridDataList = SurvivorsRogueModel.Instance.GainData.GetWeaponGridDataList(null, null);
			for (int i = 0; i < weaponGridDataList.Count; i++)
			{
				int? bondPosition = weaponGridDataList[i].BondPosition;
				int num = 0;
				if (!(bondPosition.GetValueOrDefault() == num & bondPosition != null))
				{
					return true;
				}
			}
			return false;
		}
	}
}
