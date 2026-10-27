using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D6C RID: 28012
	public class LevelConditionOnViewClose : LevelConditionBase
	{
		// Token: 0x0604477E RID: 280446 RVA: 0x010E2C18 File Offset: 0x010E0E18
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			string b = (eventArgs.Length != 0) ? ((EUiViewName)eventArgs[0]) : string.Empty;
			return limitParams == b;
		}
	}
}
