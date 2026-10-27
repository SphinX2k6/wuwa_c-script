using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004477 RID: 17527
	public class IDartMissJudgeT
	{
		// Token: 0x17007BB6 RID: 31670
		// (get) Token: 0x0601A214 RID: 107028 RVA: 0x003BB97C File Offset: 0x003B9B7C
		// (set) Token: 0x0601A215 RID: 107029 RVA: 0x003BB984 File Offset: 0x003B9B84
		public int Probability { get; set; }

		// Token: 0x17007BB7 RID: 31671
		// (get) Token: 0x0601A216 RID: 107030 RVA: 0x003BB98D File Offset: 0x003B9B8D
		// (set) Token: 0x0601A217 RID: 107031 RVA: 0x003BB995 File Offset: 0x003B9B95
		public int Range { get; set; }

		// Token: 0x0601A218 RID: 107032 RVA: 0x003BB99E File Offset: 0x003B9B9E
		public IDartMissJudgeT()
		{
			this.Probability = 0;
			this.Range = 0;
		}
	}
}
