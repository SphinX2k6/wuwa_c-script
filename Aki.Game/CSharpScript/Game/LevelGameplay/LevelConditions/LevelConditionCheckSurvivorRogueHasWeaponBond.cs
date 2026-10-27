using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D88 RID: 28040
	public class LevelConditionCheckSurvivorRogueHasWeaponBond : LevelConditionBase
	{
		// Token: 0x060447CC RID: 280524 RVA: 0x010E40C0 File Offset: 0x010E22C0
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
