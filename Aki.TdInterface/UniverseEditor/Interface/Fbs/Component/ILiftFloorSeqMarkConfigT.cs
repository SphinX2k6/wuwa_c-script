using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005504 RID: 21764
	public class ILiftFloorSeqMarkConfigT
	{
		// Token: 0x1700A0B0 RID: 41136
		// (get) Token: 0x06023F1F RID: 147231 RVA: 0x004F8234 File Offset: 0x004F6434
		// (set) Token: 0x06023F20 RID: 147232 RVA: 0x004F823C File Offset: 0x004F643C
		public string SequencePath { get; set; }

		// Token: 0x1700A0B1 RID: 41137
		// (get) Token: 0x06023F21 RID: 147233 RVA: 0x004F8245 File Offset: 0x004F6445
		// (set) Token: 0x06023F22 RID: 147234 RVA: 0x004F824D File Offset: 0x004F644D
		public List<ILiftFloorSeqMarkT> FloorMarks { get; set; }

		// Token: 0x06023F23 RID: 147235 RVA: 0x004F8256 File Offset: 0x004F6456
		public ILiftFloorSeqMarkConfigT()
		{
			this.SequencePath = null;
			this.FloorMarks = null;
		}
	}
}
