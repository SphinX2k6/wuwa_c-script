using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D6B RID: 28011
	public class LevelConditionOnUiTabViewShow : LevelConditionBase
	{
		// Token: 0x0604477C RID: 280444 RVA: 0x010E2BC0 File Offset: 0x010E0DC0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			EUiTabViewName? euiTabViewName = eventArgs[0] as EUiTabViewName?;
			string limitParams = inConditionInfo.GetLimitParams("TabViewName");
			return ((euiTabViewName != null) ? euiTabViewName.GetValueOrDefault().ToString() : null) == limitParams;
		}
	}
}
