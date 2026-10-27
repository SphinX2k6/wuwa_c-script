using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CDA RID: 27866
	public class LevelConditionCheckPopIsTargetOrEmpty : LevelConditionBase
	{
		// Token: 0x06044650 RID: 280144 RVA: 0x010DE7F4 File Offset: 0x010DC9F4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Pop);
			EUiViewName? euiViewName;
			if (topView == null)
			{
				euiViewName = null;
			}
			else
			{
				UiViewInfo viewInfo = topView.ViewInfo;
				euiViewName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
			}
			EUiViewName? euiViewName2 = euiViewName;
			if (string.IsNullOrEmpty(limitParams))
			{
				return topView == null;
			}
			return euiViewName2 != null && euiViewName2 == (EUiViewName)limitParams;
		}
	}
}
