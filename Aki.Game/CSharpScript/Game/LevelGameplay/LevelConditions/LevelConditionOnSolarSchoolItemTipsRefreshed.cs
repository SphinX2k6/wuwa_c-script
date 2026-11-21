using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE6 RID: 24294
	public class LevelConditionOnSolarSchoolItemTipsRefreshed : LevelConditionBase
	{
		// Token: 0x0603A8D8 RID: 239832 RVA: 0x0108CD3C File Offset: 0x0108AF3C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length != 0 && (int)eventArgs[0] == int.Parse(inConditionInfo.GetLimitParams("ItemId"));
		}
	}
}
