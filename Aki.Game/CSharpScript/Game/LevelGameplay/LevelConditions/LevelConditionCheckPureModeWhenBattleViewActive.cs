using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E56 RID: 24150
	public class LevelConditionCheckPureModeWhenBattleViewActive : LevelConditionBase
	{
		// Token: 0x0603A7AE RID: 239534 RVA: 0x010889D0 File Offset: 0x01086BD0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			BattleUiPureModeData pureModeData = BattleUiModel.Instance.PureModeData;
			bool flag = pureModeData != null && pureModeData.IsOpen;
			bool flag2 = UiManager.Instance.IsViewShow(EUiViewName.BattleView);
			return flag && flag2;
		}
	}
}
