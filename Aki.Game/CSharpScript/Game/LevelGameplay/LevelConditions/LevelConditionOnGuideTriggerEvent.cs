using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D5C RID: 27996
	public class LevelConditionOnGuideTriggerEvent : LevelConditionBase
	{
		// Token: 0x0604475E RID: 280414 RVA: 0x010E2758 File Offset: 0x010E0958
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			if (eventArgs.Length == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Name");
			return (string)eventArgs.GetValueOrDefault(0, null) == limitParams;
		}
	}
}
