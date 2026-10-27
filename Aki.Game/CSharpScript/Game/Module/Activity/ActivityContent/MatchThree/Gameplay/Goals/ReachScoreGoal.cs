using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x02006523 RID: 25891
	[NullableContext(1)]
	[Nullable(0)]
	public class ReachScoreGoal : LevelGoal
	{
		// Token: 0x06040EDF RID: 265951 RVA: 0x00FBBCA5 File Offset: 0x00FB9EA5
		public ReachScoreGoal(int[] targetTiers) : base(EGoalCondType.Score, targetTiers)
		{
		}

		// Token: 0x06040EE0 RID: 265952 RVA: 0x00FBBCAF File Offset: 0x00FB9EAF
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
