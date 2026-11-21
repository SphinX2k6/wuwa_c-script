using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004629 RID: 17961
	public class ITetrisSingleGridT
	{
		// Token: 0x17007DA2 RID: 32162
		// (get) Token: 0x0601A474 RID: 107636 RVA: 0x003BD825 File Offset: 0x003BBA25
		// (set) Token: 0x0601A475 RID: 107637 RVA: 0x003BD82D File Offset: 0x003BBA2D
		public ITetrisSingleBlockT Block { get; set; }

		// Token: 0x0601A476 RID: 107638 RVA: 0x003BD836 File Offset: 0x003BBA36
		public ITetrisSingleGridT()
		{
			this.Block = null;
		}
	}
}
