using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC0 RID: 27840
	public class LevelConditionCheckLockEnemyMode : LevelConditionBase
	{
		// Token: 0x06044618 RID: 280088 RVA: 0x010DD138 File Offset: 0x010DB338
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ModeIndex");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.KeyboardLockEnemyMode, true, true);
			int? currentValue2 = GameSettingsManager.Instance.GetCurrentValue(EFunction.GamepadLockEnemyMode, true, true);
			switch (Info.Instance.InputControllerMainType)
			{
			case EInputControllerMainType.Keyboard:
			{
				int num2 = num;
				int? num3 = currentValue;
				return num2 == num3.GetValueOrDefault() & num3 != null;
			}
			case EInputControllerMainType.Gamepad:
			{
				int num4 = num;
				int? num3 = currentValue2;
				return num4 == num3.GetValueOrDefault() & num3 != null;
			}
			case EInputControllerMainType.Touch:
				return num == 0;
			}
			return false;
		}
	}
}
