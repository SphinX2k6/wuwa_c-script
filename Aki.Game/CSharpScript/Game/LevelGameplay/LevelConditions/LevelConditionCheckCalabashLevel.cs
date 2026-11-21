using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DCF RID: 24015
	public class LevelConditionCheckCalabashLevel : LevelConditionBase
	{
		// Token: 0x0603A670 RID: 239216 RVA: 0x01080D54 File Offset: 0x0107EF54
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			return limitParams != null && CalabashModel.Instance.GetCalabashLevel() >= int.Parse(limitParams);
		}
	}
}
