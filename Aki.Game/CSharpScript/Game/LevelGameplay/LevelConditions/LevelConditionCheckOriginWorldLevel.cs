using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CCD RID: 27853
	public class LevelConditionCheckOriginWorldLevel : LevelConditionBase
	{
		// Token: 0x06044634 RID: 280116 RVA: 0x010DD97C File Offset: 0x010DBB7C
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
