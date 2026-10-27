using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D25 RID: 27941
	public class LevelConditionOnFloroRanchSettleViewOpenWithEndlessMode : LevelConditionBase
	{
		// Token: 0x060446EE RID: 280302 RVA: 0x010E0DC9 File Offset: 0x010DEFC9
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
