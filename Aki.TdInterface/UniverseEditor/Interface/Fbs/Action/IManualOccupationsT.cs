using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007191 RID: 29073
	public class IManualOccupationsT
	{
		// Token: 0x1700D4D1 RID: 54481
		// (get) Token: 0x060328B6 RID: 207030 RVA: 0x006D48EB File Offset: 0x006D2AEB
		// (set) Token: 0x060328B7 RID: 207031 RVA: 0x006D48F3 File Offset: 0x006D2AF3
		public EOccupationActionType OccupationType { get; set; }

		// Token: 0x1700D4D2 RID: 54482
		// (get) Token: 0x060328B8 RID: 207032 RVA: 0x006D48FC File Offset: 0x006D2AFC
		// (set) Token: 0x060328B9 RID: 207033 RVA: 0x006D4904 File Offset: 0x006D2B04
		public List<string> Occupations { get; set; }

		// Token: 0x060328BA RID: 207034 RVA: 0x006D490D File Offset: 0x006D2B0D
		public IManualOccupationsT()
		{
			this.OccupationType = EOccupationActionType.Request;
			this.Occupations = null;
		}
	}
}
