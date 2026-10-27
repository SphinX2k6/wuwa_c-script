using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D5E RID: 27998
	public class LevelConditionOnNormalTopViewChange : LevelConditionBase
	{
		// Token: 0x06044762 RID: 280418 RVA: 0x010E2834 File Offset: 0x010E0A34
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs.Length < 1)
			{
				return false;
			}
			EUiViewName left = (EUiViewName)inConditionInfo.GetLimitParams("UIName");
			EUiViewName right = (EUiViewName)eventArgs[0];
			return left == right;
		}
	}
}
