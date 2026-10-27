using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C9E RID: 27806
	public class LevelConditionCheckGolemHackingId : LevelConditionBase
	{
		// Token: 0x060445CE RID: 280014 RVA: 0x010DB9EC File Offset: 0x010D9BEC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			GolemHackingGameView golemHackingGameView = UiManager.Instance.GetViewByName(EUiViewName.GolemHackingGameView) as GolemHackingGameView;
			return golemHackingGameView != null && int.Parse(inConditionInfo.GetLimitParams("ID")) == golemHackingGameView.GetConfigId();
		}
	}
}
