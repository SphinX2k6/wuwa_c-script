using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007623 RID: 30243
	public class Record_Int_ITalkSequenceTransitionsT
	{
		// Token: 0x1700E5A8 RID: 58792
		// (get) Token: 0x06037166 RID: 225638 RVA: 0x00778ACF File Offset: 0x00776CCF
		// (set) Token: 0x06037167 RID: 225639 RVA: 0x00778AD7 File Offset: 0x00776CD7
		public int Key { get; set; }

		// Token: 0x1700E5A9 RID: 58793
		// (get) Token: 0x06037168 RID: 225640 RVA: 0x00778AE0 File Offset: 0x00776CE0
		// (set) Token: 0x06037169 RID: 225641 RVA: 0x00778AE8 File Offset: 0x00776CE8
		public List<ITalkSequenceTransitionT> Values { get; set; }

		// Token: 0x0603716A RID: 225642 RVA: 0x00778AF1 File Offset: 0x00776CF1
		public Record_Int_ITalkSequenceTransitionsT()
		{
			this.Key = 0;
			this.Values = null;
		}
	}
}
