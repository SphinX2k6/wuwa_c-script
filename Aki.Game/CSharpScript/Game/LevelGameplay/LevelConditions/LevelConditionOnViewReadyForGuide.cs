using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E9E RID: 24222
	public class LevelConditionOnViewReadyForGuide : LevelConditionBase
	{
		// Token: 0x0603A846 RID: 239686 RVA: 0x0108AE7B File Offset: 0x0108907B
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return inConditionInfo.GetLimitParams("Tag") == eventArgs[0] as string;
		}
	}
}
