using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CB6 RID: 27830
	public class LevelConditionCheckIsShowProgressBarInMapExploreDetailView : LevelConditionBase
	{
		// Token: 0x060445FF RID: 280063 RVA: 0x010DC6A8 File Offset: 0x010DA8A8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MapExploreDetailView);
			return viewByName != null && (viewByName as MapExploreDetailView).IsShowProgressBar.GetValueOrDefault();
		}
	}
}
