using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C55 RID: 27733
	public class LevelConditionCheckCalabashLevel : LevelConditionBase
	{
		// Token: 0x06044516 RID: 279830 RVA: 0x010D6DBC File Offset: 0x010D4FBC
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
