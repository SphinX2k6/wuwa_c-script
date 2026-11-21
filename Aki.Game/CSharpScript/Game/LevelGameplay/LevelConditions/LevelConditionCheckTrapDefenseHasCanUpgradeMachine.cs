using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F0F RID: 24335
	public class LevelConditionCheckTrapDefenseHasCanUpgradeMachine : LevelConditionBase
	{
		// Token: 0x0603A940 RID: 239936 RVA: 0x0108E708 File Offset: 0x0108C908
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
