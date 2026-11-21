using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EDA RID: 24282
	public class LevelConditionOnGuideTriggerEvent : LevelConditionBase
	{
		// Token: 0x0603A8C0 RID: 239808 RVA: 0x0108C910 File Offset: 0x0108AB10
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
