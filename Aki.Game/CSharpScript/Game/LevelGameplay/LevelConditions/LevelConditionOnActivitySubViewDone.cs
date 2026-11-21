using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ECF RID: 24271
	public class LevelConditionOnActivitySubViewDone : LevelConditionBase
	{
		// Token: 0x0603A8AA RID: 239786 RVA: 0x0108C6A8 File Offset: 0x0108A8A8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ActivityId");
			return limitParams != null && int.Parse(limitParams) == (int)eventArgs[0];
		}
	}
}
