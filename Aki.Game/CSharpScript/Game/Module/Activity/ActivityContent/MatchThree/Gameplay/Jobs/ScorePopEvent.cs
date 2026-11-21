using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005495 RID: 21653
	public struct ScorePopEvent
	{
		// Token: 0x06035B6D RID: 220013 RVA: 0x00F027BF File Offset: 0x00F009BF
		public ScorePopEvent(int segmentScore)
		{
			this.SegmentScore = segmentScore;
		}

		// Token: 0x0401C6EF RID: 116463
		public int SegmentScore;
	}
}
