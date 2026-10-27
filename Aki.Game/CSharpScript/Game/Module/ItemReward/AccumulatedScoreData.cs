using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D9 RID: 22489
	public class AccumulatedScoreData
	{
		// Token: 0x0401DE8D RID: 122509
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAccumulatedScoreLineData> DetailScoreDataList;

		// Token: 0x0401DE8E RID: 122510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAccumulatedScoreLineData> TotalScoreDataList;

		// Token: 0x0401DE8F RID: 122511
		public int CurScore;

		// Token: 0x0401DE90 RID: 122512
		public int MaxScore;
	}
}
