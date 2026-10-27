using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D8C RID: 28044
	public class LevelConditionTeamRoleLevel : LevelConditionBase
	{
		// Token: 0x060447D4 RID: 280532 RVA: 0x010E430C File Offset: 0x010E250C
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
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(sceneTeamItem.GetConfigId, true);
			int num2 = (roleDataById != null) ? roleDataById.GetLevelData().GetLevel() : 0;
			string limitParams2 = inConditionInfo.GetLimitParams("Op");
			return base.CheckCompareValue(limitParams2, (double)((num2 != 0) ? num2 : 0), (double)int.Parse(limitParams));
		}
	}
}
