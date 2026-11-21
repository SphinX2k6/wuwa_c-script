using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E57 RID: 24151
	public class LevelConditionCheckQuestClosedSegment : LevelConditionBase
	{
		// Token: 0x0603A7B0 RID: 239536 RVA: 0x01088A0D File Offset: 0x01086C0D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return GeneralLogicTreeModel.Instance.IsInClosedSegmentOccupation();
		}
	}
}
