using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D30 RID: 27952
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionOnNewViewCovered : LevelConditionBase
	{
		// Token: 0x06044704 RID: 280324 RVA: 0x010E10F4 File Offset: 0x010DF2F4
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("FocusView");
			EUiViewName euiViewName = (EUiViewName)eventArgs[0];
			return limitParams != euiViewName && !LevelConditionOnNewViewCovered.WhiteList.Contains(euiViewName);
		}

		// Token: 0x040239D6 RID: 145878
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
