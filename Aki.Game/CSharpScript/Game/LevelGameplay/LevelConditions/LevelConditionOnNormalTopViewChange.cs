using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EDC RID: 24284
	public class LevelConditionOnNormalTopViewChange : LevelConditionBase
	{
		// Token: 0x0603A8C4 RID: 239812 RVA: 0x0108C9EC File Offset: 0x0108ABEC
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
