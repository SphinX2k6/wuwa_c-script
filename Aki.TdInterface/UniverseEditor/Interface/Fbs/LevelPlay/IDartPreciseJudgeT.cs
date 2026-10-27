using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200447A RID: 17530
	public class IDartPreciseJudgeT
	{
		// Token: 0x17007BBA RID: 31674
		// (get) Token: 0x0601A228 RID: 107048 RVA: 0x003BBB1A File Offset: 0x003B9D1A
		// (set) Token: 0x0601A229 RID: 107049 RVA: 0x003BBB22 File Offset: 0x003B9D22
		public int Probability { get; set; }

		// Token: 0x0601A22A RID: 107050 RVA: 0x003BBB2B File Offset: 0x003B9D2B
		public IDartPreciseJudgeT()
		{
			this.Probability = 0;
		}
	}
}
