using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B0 RID: 18352
	public class AccumulatedScoreData
	{
		// Token: 0x04018924 RID: 100644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAccumulatedScoreLineData> DetailScoreDataList;

		// Token: 0x04018925 RID: 100645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAccumulatedScoreLineData> TotalScoreDataList;

		// Token: 0x04018926 RID: 100646
		public int CurScore;

		// Token: 0x04018927 RID: 100647
		public int MaxScore;
	}
}
