using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E61 RID: 24161
	public class LevelConditionCheckRoleTargetLevel : LevelConditionBase
	{
		// Token: 0x0603A7C4 RID: 239556 RVA: 0x01088E24 File Offset: 0x01087024
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
