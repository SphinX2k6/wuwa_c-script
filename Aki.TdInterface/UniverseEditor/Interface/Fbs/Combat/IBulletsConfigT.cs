using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006531 RID: 25905
	public class IBulletsConfigT
	{
		// Token: 0x1700BF1E RID: 48926
		// (get) Token: 0x0602C282 RID: 180866 RVA: 0x00603A15 File Offset: 0x00601C15
		// (set) Token: 0x0602C283 RID: 180867 RVA: 0x00603A1D File Offset: 0x00601C1D
		public List<IBulletConfigT> Bullets { get; set; }

		// Token: 0x0602C284 RID: 180868 RVA: 0x00603A26 File Offset: 0x00601C26
		public IBulletsConfigT()
		{
			this.Bullets = null;
		}
	}
}
