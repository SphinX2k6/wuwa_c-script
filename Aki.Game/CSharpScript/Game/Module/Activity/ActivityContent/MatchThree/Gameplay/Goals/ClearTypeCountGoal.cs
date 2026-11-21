using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x020054A2 RID: 21666
	[NullableContext(1)]
	[Nullable(0)]
	public class ClearTypeCountGoal : LevelGoal
	{
		// Token: 0x06035BA5 RID: 220069 RVA: 0x00F02D1D File Offset: 0x00F00F1D
		public ClearTypeCountGoal(EGoalCondType condType, EPieceType targetType, int[] targetTiers) : base(condType, targetTiers)
		{
			this.TargetType = targetType;
		}

		// Token: 0x06035BA6 RID: 220070 RVA: 0x00F02D30 File Offset: 0x00F00F30
		public override void OnSequencesSolved(SolvedData solved)
		{
			if (base.IsAchieved)
			{
				return;
			}
			List<EPieceType> clearedThisSegment = solved.ClearedThisSegment;
			for (int i = 0; i < clearedThisSegment.Count; i++)
			{
				if (clearedThisSegment[i] == this.TargetType)
				{
					int num = base.Current;
					base.Current = num + 1;
				}
			}
			if (base.Current < base.Target)
			{
				return;
			}
			base.Current = base.Target;
			base.MarkAchieved();
		}

		// Token: 0x0401C719 RID: 116505
		public readonly EPieceType TargetType;
	}
}
