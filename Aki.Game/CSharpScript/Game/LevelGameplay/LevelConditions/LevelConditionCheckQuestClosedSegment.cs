using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CDD RID: 27869
	public class LevelConditionCheckQuestClosedSegment : LevelConditionBase
	{
		// Token: 0x06044656 RID: 280150 RVA: 0x010DE92D File Offset: 0x010DCB2D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return GeneralLogicTreeModel.Instance.IsInClosedSegmentOccupation();
		}
	}
}
