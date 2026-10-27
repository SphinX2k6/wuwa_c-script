using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D17 RID: 27927
	public class LevelConditionCheckDangoMonopolyHasFinishedRound : LevelConditionBase
	{
		// Token: 0x060446D2 RID: 280274 RVA: 0x010E0A49 File Offset: 0x010DEC49
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
			return ((data != null) ? data.GetFinishedRoundNum() : 0) > 0;
		}
	}
}
