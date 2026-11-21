using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB1 RID: 24241
	public class ISceneBulletComponentT
	{
		// Token: 0x1700B314 RID: 45844
		// (get) Token: 0x060289E2 RID: 166370 RVA: 0x0058DAAB File Offset: 0x0058BCAB
		// (set) Token: 0x060289E3 RID: 166371 RVA: 0x0058DAB3 File Offset: 0x0058BCB3
		public bool Disabled { get; set; }

		// Token: 0x1700B315 RID: 45845
		// (get) Token: 0x060289E4 RID: 166372 RVA: 0x0058DABC File Offset: 0x0058BCBC
		// (set) Token: 0x060289E5 RID: 166373 RVA: 0x0058DAC4 File Offset: 0x0058BCC4
		public bool DisableGenerateByRange { get; set; }

		// Token: 0x1700B316 RID: 45846
		// (get) Token: 0x060289E6 RID: 166374 RVA: 0x0058DACD File Offset: 0x0058BCCD
		// (set) Token: 0x060289E7 RID: 166375 RVA: 0x0058DAD5 File Offset: 0x0058BCD5
		public List<ISceneBulletGroupT> BulletGroups { get; set; }

		// Token: 0x1700B317 RID: 45847
		// (get) Token: 0x060289E8 RID: 166376 RVA: 0x0058DADE File Offset: 0x0058BCDE
		// (set) Token: 0x060289E9 RID: 166377 RVA: 0x0058DAE6 File Offset: 0x0058BCE6
		public byte NullMask { get; set; }

		// Token: 0x060289EA RID: 166378 RVA: 0x0058DAEF File Offset: 0x0058BCEF
		public ISceneBulletComponentT()
		{
			this.Disabled = false;
			this.DisableGenerateByRange = false;
			this.BulletGroups = null;
			this.NullMask = 0;
		}
	}
}
