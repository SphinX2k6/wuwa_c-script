using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006856 RID: 26710
	public class IForceOccupationsT
	{
		// Token: 0x1700C662 RID: 50786
		// (get) Token: 0x0602E929 RID: 190761 RVA: 0x0065A74B File Offset: 0x0065894B
		// (set) Token: 0x0602E92A RID: 190762 RVA: 0x0065A753 File Offset: 0x00658953
		public EOccupationActionType OccupationType { get; set; }

		// Token: 0x1700C663 RID: 50787
		// (get) Token: 0x0602E92B RID: 190763 RVA: 0x0065A75C File Offset: 0x0065895C
		// (set) Token: 0x0602E92C RID: 190764 RVA: 0x0065A764 File Offset: 0x00658964
		public List<string> Occupations { get; set; }

		// Token: 0x0602E92D RID: 190765 RVA: 0x0065A76D File Offset: 0x0065896D
		public IForceOccupationsT()
		{
			this.OccupationType = EOccupationActionType.Request;
			this.Occupations = null;
		}
	}
}
