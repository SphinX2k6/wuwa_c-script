using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CA3 RID: 27811
	public class LevelConditionCheckHasFirstPhantomAtPosition : LevelConditionBase
	{
		// Token: 0x060445D8 RID: 280024 RVA: 0x010DBC98 File Offset: 0x010D9E98
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
			if (int.Parse(inConditionInfo.GetLimitParams("IsFull")) == 1)
			{
				foreach (SceneTeamItem sceneTeamItem in teamItems)
				{
					if (PhantomBattleController.Instance.GetEquipByIndex(sceneTeamItem.GetConfigId, 0) == 0)
					{
						return false;
					}
				}
				return true;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("Position"));
			bool flag = int.Parse(inConditionInfo.GetLimitParams("Available")) == 1;
			if (num > teamItems.Count)
			{
				return false;
			}
			SceneTeamItem sceneTeamItem2 = teamItems[num - 1];
			return PhantomBattleController.Instance.GetEquipByIndex(sceneTeamItem2.GetConfigId, 0) != 0 == flag;
		}
	}
}
