using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6F RID: 27247
	public class IManualOccupationsT
	{
		// Token: 0x1700CA26 RID: 51750
		// (get) Token: 0x0602FB90 RID: 195472 RVA: 0x0067E82B File Offset: 0x0067CA2B
		// (set) Token: 0x0602FB91 RID: 195473 RVA: 0x0067E833 File Offset: 0x0067CA33
		public EOccupationActionType OccupationType { get; set; }

		// Token: 0x1700CA27 RID: 51751
		// (get) Token: 0x0602FB92 RID: 195474 RVA: 0x0067E83C File Offset: 0x0067CA3C
		// (set) Token: 0x0602FB93 RID: 195475 RVA: 0x0067E844 File Offset: 0x0067CA44
		public List<string> Occupations { get; set; }

		// Token: 0x0602FB94 RID: 195476 RVA: 0x0067E84D File Offset: 0x0067CA4D
		public IManualOccupationsT()
		{
			this.OccupationType = EOccupationActionType.Request;
			this.Occupations = null;
		}
	}
}
