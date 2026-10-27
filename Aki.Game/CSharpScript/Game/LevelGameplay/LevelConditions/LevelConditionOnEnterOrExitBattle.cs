using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D57 RID: 27991
	public class LevelConditionOnEnterOrExitBattle : LevelConditionBase
	{
		// Token: 0x06044754 RID: 280404 RVA: 0x010E2638 File Offset: 0x010E0838
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("CheckValue");
			if (limitParams == null)
			{
				return false;
			}
			bool flag = limitParams == "TRUE";
			return (bool)eventArgs[0] == flag;
		}
	}
}
