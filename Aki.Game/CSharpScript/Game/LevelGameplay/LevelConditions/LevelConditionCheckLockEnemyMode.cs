using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E3A RID: 24122
	public class LevelConditionCheckLockEnemyMode : LevelConditionBase
	{
		// Token: 0x0603A772 RID: 239474 RVA: 0x0108718C File Offset: 0x0108538C
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
