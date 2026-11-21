using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED0 RID: 24272
	public class LevelConditionOnChangeBossRushBuff : LevelConditionBase
	{
		// Token: 0x0603A8AC RID: 239788 RVA: 0x0108C6E0 File Offset: 0x0108A8E0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Tab");
			return limitParams != null && (EUiTabViewName)eventArgs[0] == (EUiTabViewName)limitParams;
		}
	}
}
