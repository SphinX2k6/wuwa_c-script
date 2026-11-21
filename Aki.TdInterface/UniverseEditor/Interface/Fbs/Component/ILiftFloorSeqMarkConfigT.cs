using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8A RID: 23178
	public class ILiftFloorSeqMarkConfigT
	{
		// Token: 0x1700A8EA RID: 43242
		// (get) Token: 0x06025FD9 RID: 155609 RVA: 0x00535358 File Offset: 0x00533558
		// (set) Token: 0x06025FDA RID: 155610 RVA: 0x00535360 File Offset: 0x00533560
		public string SequencePath { get; set; }

		// Token: 0x1700A8EB RID: 43243
		// (get) Token: 0x06025FDB RID: 155611 RVA: 0x00535369 File Offset: 0x00533569
		// (set) Token: 0x06025FDC RID: 155612 RVA: 0x00535371 File Offset: 0x00533571
		public List<ILiftFloorSeqMarkT> FloorMarks { get; set; }

		// Token: 0x06025FDD RID: 155613 RVA: 0x0053537A File Offset: 0x0053357A
		public ILiftFloorSeqMarkConfigT()
		{
			this.SequencePath = null;
			this.FloorMarks = null;
		}
	}
}
