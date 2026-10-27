using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D53 RID: 27987
	public class LevelConditionOnChangeBossRushBuff : LevelConditionBase
	{
		// Token: 0x0604474C RID: 280396 RVA: 0x010E2554 File Offset: 0x010E0754
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Tab");
			return limitParams != null && (EUiTabViewName)eventArgs[0] == (EUiTabViewName)limitParams;
		}
	}
}
