using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CD1 RID: 27857
	public class LevelConditionCheckPinballPass : LevelConditionBase
	{
		// Token: 0x0604463C RID: 280124 RVA: 0x010DDA58 File Offset: 0x010DBC58
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
