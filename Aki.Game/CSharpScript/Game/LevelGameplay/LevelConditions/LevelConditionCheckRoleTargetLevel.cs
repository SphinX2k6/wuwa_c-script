using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CE7 RID: 27879
	public class LevelConditionCheckRoleTargetLevel : LevelConditionBase
	{
		// Token: 0x0604466A RID: 280170 RVA: 0x010DED44 File Offset: 0x010DCF44
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			int level = (limitParams != null) ? int.Parse(limitParams) : 0;
			return RoleController.Instance.CheckRoleTargetLevel(level);
		}
	}
}
