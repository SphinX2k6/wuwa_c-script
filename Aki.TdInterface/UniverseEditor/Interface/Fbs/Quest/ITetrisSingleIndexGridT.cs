using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200462C RID: 17964
	public class ITetrisSingleIndexGridT
	{
		// Token: 0x17007DA6 RID: 32166
		// (get) Token: 0x0601A488 RID: 107656 RVA: 0x003BDA7F File Offset: 0x003BBC7F
		// (set) Token: 0x0601A489 RID: 107657 RVA: 0x003BDA87 File Offset: 0x003BBC87
		public int Index { get; set; }

		// Token: 0x17007DA7 RID: 32167
		// (get) Token: 0x0601A48A RID: 107658 RVA: 0x003BDA90 File Offset: 0x003BBC90
		// (set) Token: 0x0601A48B RID: 107659 RVA: 0x003BDA98 File Offset: 0x003BBC98
		public ITetrisSingleGridT Value { get; set; }

		// Token: 0x0601A48C RID: 107660 RVA: 0x003BDAA1 File Offset: 0x003BBCA1
		public ITetrisSingleIndexGridT()
		{
			this.Index = 0;
			this.Value = null;
		}
	}
}
