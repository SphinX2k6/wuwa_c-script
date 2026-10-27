using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D7B RID: 28027
	public class LevelConditionRoleBreach : LevelConditionBase
	{
		// Token: 0x060447AF RID: 280495 RVA: 0x010E3AB0 File Offset: 0x010E1CB0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Breach");
			if (limitParams == null)
			{
				return false;
			}
			int id = 0;
			string limitParams2 = inConditionInfo.GetLimitParams("RoleId");
			if (limitParams2 != null)
			{
				id = int.Parse(limitParams2);
			}
			if (eventArgs.Length != 0)
			{
				id = (int)eventArgs[0];
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
			if (roleDataById == null)
			{
				return false;
			}
			if (roleDataById is RoleInstance)
			{
				RoleLevelData levelData = roleDataById.GetLevelData();
				return levelData.GetBreachLevel() != 0 && levelData.GetBreachLevel() >= int.Parse(limitParams);
			}
			return false;
		}
	}
}
