using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E3B RID: 24123
	public class LevelConditionCheckMapFocusByQuestId : LevelConditionBase
	{
		// Token: 0x0603A774 RID: 239476 RVA: 0x01087238 File Offset: 0x01085438
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			if (eventArgs.Length < 1)
			{
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("QuestId"));
			int num2 = (int)eventArgs[0];
			return num == num2;
		}
	}
}
