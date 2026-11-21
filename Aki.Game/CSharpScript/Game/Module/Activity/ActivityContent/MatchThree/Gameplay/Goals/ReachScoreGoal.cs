using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x020054A1 RID: 21665
	[NullableContext(1)]
	[Nullable(0)]
	public class ReachScoreGoal : LevelGoal
	{
		// Token: 0x06035BA3 RID: 220067 RVA: 0x00F02CD5 File Offset: 0x00F00ED5
		public ReachScoreGoal(int[] targetTiers) : base(EGoalCondType.Score, targetTiers)
		{
		}

		// Token: 0x06035BA4 RID: 220068 RVA: 0x00F02CDF File Offset: 0x00F00EDF
		public override void OnSequencesSolved(SolvedData solved)
		{
			if (base.IsAchieved)
			{
				return;
			}
			base.Current += solved.SegmentScore;
			if (base.Current >= base.Target)
			{
				base.Current = base.Target;
				base.MarkAchieved();
			}
		}
	}
}
