using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CF0 RID: 27888
	public class LevelConditionCheckTeamRoleCouldLevelUp : LevelConditionBase
	{
		// Token: 0x06044683 RID: 280195 RVA: 0x010DF560 File Offset: 0x010DD760
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			ItemInfo[] roleCostExpList = RoleModel.Instance.GetRoleCostExpList();
			bool flag = false;
			foreach (ItemInfo itemInfo in roleCostExpList)
			{
				if (InventoryModel.Instance.GetItemCountByConfigId(itemInfo.Id, 0) > 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				int getConfigId = sceneTeamItem.GetConfigId;
				RoleLevelData levelData = RoleModel.Instance.GetRoleDataById(getConfigId, true).GetLevelData();
				if (levelData.GetLevel() < levelData.GetCurrentMaxLevel())
				{
					return true;
				}
			}
			return false;
		}
	}
}
