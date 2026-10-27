using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D8D RID: 28045
	public class LevelConditionTeamWeaponLevel : LevelConditionBase
	{
		// Token: 0x060447D6 RID: 280534 RVA: 0x010E43C0 File Offset: 0x010E25C0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("Position"));
			SceneTeamItem sceneTeamItem = SceneTeamModel.Instance.GetTeamItems(true)[num - 1];
			if (sceneTeamItem == null || !sceneTeamItem.IsMyRole())
			{
				return false;
			}
			WeaponInstance weaponInstance = WeaponModel.Instance.GetWeaponDataByRoleDataId(sceneTeamItem.GetConfigId, true) as WeaponInstance;
			if (weaponInstance == null)
			{
				return false;
			}
			string limitParams2 = inConditionInfo.GetLimitParams("Op");
			return base.CheckCompareValue(limitParams2, (double)weaponInstance.GetLevel(), (double)int.Parse(limitParams));
		}
	}
}
