using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EEA RID: 24298
	public class LevelConditionOnUiTabViewShow : LevelConditionBase
	{
		// Token: 0x0603A8E0 RID: 239840 RVA: 0x0108CDA4 File Offset: 0x0108AFA4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			EUiTabViewName? euiTabViewName = eventArgs[0] as EUiTabViewName?;
			string limitParams = inConditionInfo.GetLimitParams("TabViewName");
			return ((euiTabViewName != null) ? euiTabViewName.GetValueOrDefault().ToString() : null) == limitParams;
		}
	}
}
