using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D7C RID: 28028
	public class LevelConditionRoleLevel : LevelConditionBase
	{
		// Token: 0x060447B1 RID: 280497 RVA: 0x010E3B4C File Offset: 0x010E1D4C
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
			string limitParams2 = inConditionInfo.GetLimitParams("RoleId");
			int? num = (limitParams2 != null) ? new int?(int.Parse(limitParams2)) : RoleModel.Instance.GetBattleTeamFirstRoleId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num.Value, true);
			if (roleDataById == null)
			{
				return false;
			}
			RoleLevelData levelData = roleDataById.GetLevelData();
			return levelData.GetLevel() != 0 && levelData.GetLevel() >= int.Parse(limitParams);
		}
	}
}
