using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E6E RID: 24174
	public class LevelConditionCheckTeamWeaponCouldLevelUp : LevelConditionBase
	{
		// Token: 0x0603A7E5 RID: 239589 RVA: 0x01089810 File Offset: 0x01087A10
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				int getConfigId = sceneTeamItem.GetConfigId;
				WeaponInstance weaponInstance = WeaponModel.Instance.GetWeaponDataByRoleDataId(getConfigId, true) as WeaponInstance;
				if (weaponInstance != null && weaponInstance != null)
				{
					List<ItemDataBase> weaponExpItemList = WeaponModel.Instance.GetWeaponExpItemList(weaponInstance.GetIncId());
					bool flag = false;
					foreach (ItemDataBase itemDataBase in weaponExpItemList)
					{
						if (InventoryModel.Instance.GetItemCountByConfigId(itemDataBase.GetConfigId(), 0) > 0)
						{
							flag = true;
							break;
						}
					}
					if (flag && weaponInstance.GetLevel() < weaponInstance.GetCurrentMaxLevel())
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
