using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EAD RID: 24237
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionOnNewViewCovered : LevelConditionBase
	{
		// Token: 0x0603A864 RID: 239716 RVA: 0x0108B280 File Offset: 0x01089480
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("FocusView");
			EUiViewName euiViewName = (EUiViewName)eventArgs[0];
			return limitParams != euiViewName && !LevelConditionOnNewViewCovered.WhiteList.Contains(euiViewName);
		}

		// Token: 0x0401EC78 RID: 126072
		[StaticVariableRuleIgnore]
		private static readonly HashSet<EUiViewName> WhiteList = new HashSet<EUiViewName>
		{
			EUiViewName.GuideFocusView,
			EUiViewName.GuideTipsView,
			EUiViewName.GuideTutorialView,
			EUiViewName.GuideTutorialPopView,
			EUiViewName.GuideTutorialTipsView,
			EUiViewName.NetWorkMaskView
		};
	}
}
