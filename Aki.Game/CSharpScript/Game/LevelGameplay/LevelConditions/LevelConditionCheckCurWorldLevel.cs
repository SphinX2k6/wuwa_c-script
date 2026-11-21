using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DE1 RID: 24033
	public class LevelConditionCheckCurWorldLevel : LevelConditionBase
	{
		// Token: 0x0603A6B0 RID: 239280 RVA: 0x010826A8 File Offset: 0x010808A8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
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
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			return curWorldLevel != 0 && curWorldLevel >= int.Parse(limitParams);
		}
	}
}
