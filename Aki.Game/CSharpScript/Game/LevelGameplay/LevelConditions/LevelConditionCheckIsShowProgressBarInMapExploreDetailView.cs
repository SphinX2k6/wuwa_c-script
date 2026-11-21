using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E30 RID: 24112
	public class LevelConditionCheckIsShowProgressBarInMapExploreDetailView : LevelConditionBase
	{
		// Token: 0x0603A759 RID: 239449 RVA: 0x01086654 File Offset: 0x01084854
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MapExploreDetailView);
			return viewByName != null && (viewByName as MapExploreDetailView).IsShowProgressBar.GetValueOrDefault();
		}
	}
}
