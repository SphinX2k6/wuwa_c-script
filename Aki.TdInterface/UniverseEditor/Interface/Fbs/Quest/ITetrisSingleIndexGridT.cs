using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D3 RID: 16851
	public class ITetrisSingleIndexGridT
	{
		// Token: 0x1700777A RID: 30586
		// (get) Token: 0x06018D32 RID: 101682 RVA: 0x0039262B File Offset: 0x0039082B
		// (set) Token: 0x06018D33 RID: 101683 RVA: 0x00392633 File Offset: 0x00390833
		public int Index { get; set; }

		// Token: 0x1700777B RID: 30587
		// (get) Token: 0x06018D34 RID: 101684 RVA: 0x0039263C File Offset: 0x0039083C
		// (set) Token: 0x06018D35 RID: 101685 RVA: 0x00392644 File Offset: 0x00390844
		public ITetrisSingleGridT Value { get; set; }

		// Token: 0x06018D36 RID: 101686 RVA: 0x0039264D File Offset: 0x0039084D
		public ITetrisSingleIndexGridT()
		{
			this.Index = 0;
			this.Value = null;
		}
	}
}
