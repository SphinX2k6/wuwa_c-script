using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E6D RID: 24173
	public class LevelConditionCheckTeamRoleCouldLevelUp : LevelConditionBase
	{
		// Token: 0x0603A7E3 RID: 239587 RVA: 0x01089740 File Offset: 0x01087940
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
