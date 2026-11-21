using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E18 RID: 24088
	public class LevelConditionCheckGolemHackingId : LevelConditionBase
	{
		// Token: 0x0603A728 RID: 239400 RVA: 0x01085998 File Offset: 0x01083B98
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			GolemHackingGameView golemHackingGameView = UiManager.Instance.GetViewByName(EUiViewName.GolemHackingGameView) as GolemHackingGameView;
			return golemHackingGameView != null && int.Parse(inConditionInfo.GetLimitParams("ID")) == golemHackingGameView.GetConfigId();
		}
	}
}
