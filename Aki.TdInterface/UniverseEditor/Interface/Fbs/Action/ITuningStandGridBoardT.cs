using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749A RID: 29850
	public class ITuningStandGridBoardT
	{
		// Token: 0x1700E2A8 RID: 58024
		// (get) Token: 0x06036432 RID: 222258 RVA: 0x00760609 File Offset: 0x0075E809
		// (set) Token: 0x06036433 RID: 222259 RVA: 0x00760611 File Offset: 0x0075E811
		public List<ETuningStandGridType> Grids { get; set; }

		// Token: 0x06036434 RID: 222260 RVA: 0x0076061A File Offset: 0x0075E81A
		public ITuningStandGridBoardT()
		{
			this.Grids = null;
		}
	}
}
