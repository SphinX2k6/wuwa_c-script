using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x02006524 RID: 25892
	[NullableContext(1)]
	[Nullable(0)]
	public class ClearTypeCountGoal : LevelGoal
	{
		// Token: 0x06040EE1 RID: 265953 RVA: 0x00FBBCED File Offset: 0x00FB9EED
		public ClearTypeCountGoal(EGoalCondType condType, EPieceType targetType, int[] targetTiers) : base(condType, targetTiers)
		{
			this.TargetType = targetType;
		}

		// Token: 0x06040EE2 RID: 265954 RVA: 0x00FBBD00 File Offset: 0x00FB9F00
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

		// Token: 0x04021DE8 RID: 138728
		public readonly EPieceType TargetType;
	}
}
