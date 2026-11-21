using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E60 RID: 24160
	public class LevelConditionCheckRoleSkillTargetLevel : LevelConditionBase
	{
		// Token: 0x0603A7C2 RID: 239554 RVA: 0x01088DDC File Offset: 0x01086FDC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			int level = (limitParams != null) ? int.Parse(limitParams) : 0;
			return RoleController.Instance.CheckRoleSkillTargetLevel(level);
		}
	}
}
