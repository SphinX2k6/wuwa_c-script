using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E7A RID: 24186
	public class LevelConditionCheckUIOpenDone : LevelConditionBase
	{
		// Token: 0x0603A7FD RID: 239613 RVA: 0x01089F24 File Offset: 0x01088124
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs.Length < 1)
			{
				return false;
			}
			EUiViewName name = (EUiViewName)eventArgs[0];
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			return limitParams != null && !(name != limitParams) && UiManager.Instance.IsViewOpen((EUiViewName)limitParams);
		}
	}
}
