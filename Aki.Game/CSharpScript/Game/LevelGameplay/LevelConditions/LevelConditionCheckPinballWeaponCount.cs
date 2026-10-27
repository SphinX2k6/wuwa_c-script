using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CD2 RID: 27858
	public class LevelConditionCheckPinballWeaponCount : LevelConditionBase
	{
		// Token: 0x0604463E RID: 280126 RVA: 0x010DDAB0 File Offset: 0x010DBCB0
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
