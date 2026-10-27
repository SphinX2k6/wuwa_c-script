using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C67 RID: 27751
	public class LevelConditionCheckCurWorldLevel : LevelConditionBase
	{
		// Token: 0x06044556 RID: 279894 RVA: 0x010D8710 File Offset: 0x010D6910
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
