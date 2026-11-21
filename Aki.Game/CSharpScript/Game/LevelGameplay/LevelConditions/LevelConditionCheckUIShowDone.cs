using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E7B RID: 24187
	public class LevelConditionCheckUIShowDone : LevelConditionBase
	{
		// Token: 0x0603A7FF RID: 239615 RVA: 0x01089F7C File Offset: 0x0108817C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs.Length < 1)
			{
				return false;
			}
			EUiViewName name = (EUiViewName)eventArgs[0];
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			return limitParams != null && !(name != limitParams);
		}
	}
}
