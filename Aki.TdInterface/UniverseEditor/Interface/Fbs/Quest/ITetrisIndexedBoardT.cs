using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BB RID: 16827
	public class ITetrisIndexedBoardT
	{
		// Token: 0x17007753 RID: 30547
		// (get) Token: 0x06018C80 RID: 101504 RVA: 0x00391471 File Offset: 0x0038F671
		// (set) Token: 0x06018C81 RID: 101505 RVA: 0x00391479 File Offset: 0x0038F679
		public List<ITetrisSingleIndexGridT> IndexedGrids { get; set; }

		// Token: 0x17007754 RID: 30548
		// (get) Token: 0x06018C82 RID: 101506 RVA: 0x00391482 File Offset: 0x0038F682
		// (set) Token: 0x06018C83 RID: 101507 RVA: 0x0039148A File Offset: 0x0038F68A
		public IRequiredVector2T BoardSize { get; set; }

		// Token: 0x06018C84 RID: 101508 RVA: 0x00391493 File Offset: 0x0038F693
		public ITetrisIndexedBoardT()
		{
			this.IndexedGrids = null;
			this.BoardSize = null;
		}
	}
}
