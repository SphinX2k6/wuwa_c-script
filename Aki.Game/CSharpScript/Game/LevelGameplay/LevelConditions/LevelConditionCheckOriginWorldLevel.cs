using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E47 RID: 24135
	public class LevelConditionCheckOriginWorldLevel : LevelConditionBase
	{
		// Token: 0x0603A78E RID: 239502 RVA: 0x010879D0 File Offset: 0x01085BD0
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
			int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
			return originWorldLevel != 0 && originWorldLevel >= int.Parse(limitParams);
		}
	}
}
