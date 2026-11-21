using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DA RID: 30682
	public class ISetJigsawItemT
	{
		// Token: 0x1700E0E1 RID: 57569
		// (get) Token: 0x06035E53 RID: 220755 RVA: 0x00738799 File Offset: 0x00736999
		// (set) Token: 0x06035E54 RID: 220756 RVA: 0x007387A1 File Offset: 0x007369A1
		public IMoveJigsawItemT Config { get; set; }

		// Token: 0x06035E55 RID: 220757 RVA: 0x007387AA File Offset: 0x007369AA
		public ISetJigsawItemT()
		{
			this.Config = null;
		}
	}
}
