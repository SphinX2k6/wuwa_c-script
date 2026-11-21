using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E31 RID: 32305
	public class Record_Int_ITalkSequenceTransitionsT
	{
		// Token: 0x1700F1E6 RID: 61926
		// (get) Token: 0x0603A60B RID: 239115 RVA: 0x007DCBCB File Offset: 0x007DADCB
		// (set) Token: 0x0603A60C RID: 239116 RVA: 0x007DCBD3 File Offset: 0x007DADD3
		public int Key { get; set; }

		// Token: 0x1700F1E7 RID: 61927
		// (get) Token: 0x0603A60D RID: 239117 RVA: 0x007DCBDC File Offset: 0x007DADDC
		// (set) Token: 0x0603A60E RID: 239118 RVA: 0x007DCBE4 File Offset: 0x007DADE4
		public List<ITalkSequenceTransitionT> Values { get; set; }

		// Token: 0x0603A60F RID: 239119 RVA: 0x007DCBED File Offset: 0x007DADED
		public Record_Int_ITalkSequenceTransitionsT()
		{
			this.Key = 0;
			this.Values = null;
		}
	}
}
