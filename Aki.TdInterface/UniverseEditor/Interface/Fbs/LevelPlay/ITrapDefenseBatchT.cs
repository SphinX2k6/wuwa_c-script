using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A1D RID: 18973
	public class ITrapDefenseBatchT
	{
		// Token: 0x17008519 RID: 34073
		// (get) Token: 0x0601C79C RID: 116636 RVA: 0x0040541B File Offset: 0x0040361B
		// (set) Token: 0x0601C79D RID: 116637 RVA: 0x00405423 File Offset: 0x00403623
		public List<int> Ids { get; set; }

		// Token: 0x1700851A RID: 34074
		// (get) Token: 0x0601C79E RID: 116638 RVA: 0x0040542C File Offset: 0x0040362C
		// (set) Token: 0x0601C79F RID: 116639 RVA: 0x00405434 File Offset: 0x00403634
		public int RepeatTimes { get; set; }

		// Token: 0x0601C7A0 RID: 116640 RVA: 0x0040543D File Offset: 0x0040363D
		public ITrapDefenseBatchT()
		{
			this.Ids = null;
			this.RepeatTimes = 0;
		}
	}
}
