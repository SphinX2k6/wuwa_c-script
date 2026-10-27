using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CFC RID: 27900
	public class LevelConditionCheckUIOpen : LevelConditionBase
	{
		// Token: 0x0604469B RID: 280219 RVA: 0x010DFD60 File Offset: 0x010DDF60
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			return limitParams != null && UiManager.Instance.IsViewOpen((EUiViewName)limitParams);
		}
	}
}
