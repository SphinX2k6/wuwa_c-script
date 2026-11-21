using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E4B RID: 24139
	public class LevelConditionCheckPinballPass : LevelConditionBase
	{
		// Token: 0x0603A796 RID: 239510 RVA: 0x01087AAC File Offset: 0x01085CAC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("LevelId");
			int num;
			return !string.IsNullOrEmpty(limitParams) && int.TryParse(limitParams, out num) && num > 0 && PinballModel.Instance.ActivityData.IsLevelPassed(num);
		}
	}
}
