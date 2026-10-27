using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006517 RID: 25879
	public struct ScorePopEvent
	{
		// Token: 0x06040EA9 RID: 265897 RVA: 0x00FBB78F File Offset: 0x00FB998F
		public ScorePopEvent(int segmentScore)
		{
			this.SegmentScore = segmentScore;
		}

		// Token: 0x04021DBE RID: 138686
		public int SegmentScore;
	}
}
