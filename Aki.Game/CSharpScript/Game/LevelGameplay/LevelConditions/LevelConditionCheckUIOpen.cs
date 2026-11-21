using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E79 RID: 24185
	public class LevelConditionCheckUIOpen : LevelConditionBase
	{
		// Token: 0x0603A7FB RID: 239611 RVA: 0x01089EEC File Offset: 0x010880EC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			return limitParams != null && UiManager.Instance.IsViewOpen((EUiViewName)limitParams);
		}
	}
}
