using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CDC RID: 27868
	public class LevelConditionCheckPureModeWhenBattleViewActive : LevelConditionBase
	{
		// Token: 0x06044654 RID: 280148 RVA: 0x010DE8F0 File Offset: 0x010DCAF0
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
