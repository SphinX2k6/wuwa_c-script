using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E4C RID: 24140
	public class LevelConditionCheckPinballWeaponCount : LevelConditionBase
	{
		// Token: 0x0603A798 RID: 239512 RVA: 0x01087B04 File Offset: 0x01085D04
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Count");
			int num;
			return !string.IsNullOrEmpty(limitParams) && int.TryParse(limitParams, out num) && num >= 0 && PinballModel.Instance.GetAllWeaponDataList().Count >= num;
		}
	}
}
