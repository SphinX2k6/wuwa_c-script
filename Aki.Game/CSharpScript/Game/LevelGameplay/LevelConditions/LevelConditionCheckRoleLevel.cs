using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E5E RID: 24158
	public class LevelConditionCheckRoleLevel : LevelConditionBase
	{
		// Token: 0x0603A7BE RID: 239550 RVA: 0x01088CE8 File Offset: 0x01086EE8
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
			if (limitParams2 == null)
			{
				return false;
			}
			int id = int.Parse(limitParams2);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
			RoleLevelData roleLevelData = (roleDataById != null) ? roleDataById.GetLevelData() : null;
			if (roleLevelData == null)
			{
				return false;
			}
			string limitParams3 = inConditionInfo.GetLimitParams("Op");
			return base.CheckCompareValue(limitParams3, (double)roleLevelData.GetLevel(), (double)int.Parse(limitParams));
		}
	}
}
