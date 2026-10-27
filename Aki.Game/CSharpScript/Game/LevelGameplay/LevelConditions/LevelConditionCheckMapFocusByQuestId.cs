using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC1 RID: 27841
	public class LevelConditionCheckMapFocusByQuestId : LevelConditionBase
	{
		// Token: 0x0604461A RID: 280090 RVA: 0x010DD1E4 File Offset: 0x010DB3E4
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
