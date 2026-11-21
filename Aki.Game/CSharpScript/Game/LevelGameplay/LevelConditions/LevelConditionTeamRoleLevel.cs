using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F0B RID: 24331
	public class LevelConditionTeamRoleLevel : LevelConditionBase
	{
		// Token: 0x0603A938 RID: 239928 RVA: 0x0108E534 File Offset: 0x0108C734
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
