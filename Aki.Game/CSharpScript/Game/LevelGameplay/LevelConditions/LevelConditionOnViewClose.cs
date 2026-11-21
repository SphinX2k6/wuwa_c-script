using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EEB RID: 24299
	public class LevelConditionOnViewClose : LevelConditionBase
	{
		// Token: 0x0603A8E2 RID: 239842 RVA: 0x0108CDFC File Offset: 0x0108AFFC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			string b = (eventArgs.Length != 0) ? ((EUiViewName)eventArgs[0]) : string.Empty;
			return limitParams == b;
		}
	}
}
