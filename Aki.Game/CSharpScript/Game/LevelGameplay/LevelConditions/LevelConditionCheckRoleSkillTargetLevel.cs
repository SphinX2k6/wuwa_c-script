using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CE6 RID: 27878
	public class LevelConditionCheckRoleSkillTargetLevel : LevelConditionBase
	{
		// Token: 0x06044668 RID: 280168 RVA: 0x010DECFC File Offset: 0x010DCEFC
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
