using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D52 RID: 27986
	public class LevelConditionOnActivitySubViewDone : LevelConditionBase
	{
		// Token: 0x0604474A RID: 280394 RVA: 0x010E251C File Offset: 0x010E071C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ActivityId");
			return limitParams != null && int.Parse(limitParams) == (int)eventArgs[0];
		}
	}
}
