using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E94 RID: 24212
	public class LevelConditionCheckDangoMonopolyHasFinishedRound : LevelConditionBase
	{
		// Token: 0x0603A832 RID: 239666 RVA: 0x0108ABD5 File Offset: 0x01088DD5
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
			return ((data != null) ? data.GetFinishedRoundNum() : 0) > 0;
		}
	}
}
