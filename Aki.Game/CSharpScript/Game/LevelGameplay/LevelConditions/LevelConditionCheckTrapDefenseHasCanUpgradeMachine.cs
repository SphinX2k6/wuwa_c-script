using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D90 RID: 28048
	public class LevelConditionCheckTrapDefenseHasCanUpgradeMachine : LevelConditionBase
	{
		// Token: 0x060447DC RID: 280540 RVA: 0x010E44E0 File Offset: 0x010E26E0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			List<List<TrapDefenseBuildingDevelopItemData>> haveList = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetHaveList();
			for (int i = 0; i < haveList.Count; i++)
			{
				List<TrapDefenseBuildingDevelopItemData> list = haveList[i];
				int num = 0;
				if (num < list.Count)
				{
					return !list[num].GetIsMaxLevel(false);
				}
			}
			return false;
		}
	}
}
