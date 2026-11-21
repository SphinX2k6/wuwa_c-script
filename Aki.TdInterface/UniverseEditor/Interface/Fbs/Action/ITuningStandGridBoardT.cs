using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C8D RID: 31885
	public class ITuningStandGridBoardT
	{
		// Token: 0x1700EEC7 RID: 61127
		// (get) Token: 0x0603981F RID: 235551 RVA: 0x007C33C5 File Offset: 0x007C15C5
		// (set) Token: 0x06039820 RID: 235552 RVA: 0x007C33CD File Offset: 0x007C15CD
		public List<ETuningStandGridType> Grids { get; set; }

		// Token: 0x06039821 RID: 235553 RVA: 0x007C33D6 File Offset: 0x007C15D6
		public ITuningStandGridBoardT()
		{
			this.Grids = null;
		}
	}
}
