using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005109 RID: 20745
	public class IEditCustomAoiComponentT
	{
		// Token: 0x17009729 RID: 38697
		// (get) Token: 0x060216D4 RID: 136916 RVA: 0x004A42F9 File Offset: 0x004A24F9
		// (set) Token: 0x060216D5 RID: 136917 RVA: 0x004A4301 File Offset: 0x004A2501
		public bool Disabled { get; set; }

		// Token: 0x1700972A RID: 38698
		// (get) Token: 0x060216D6 RID: 136918 RVA: 0x004A430A File Offset: 0x004A250A
		// (set) Token: 0x060216D7 RID: 136919 RVA: 0x004A4312 File Offset: 0x004A2512
		public List<int> Entities { get; set; }

		// Token: 0x1700972B RID: 38699
		// (get) Token: 0x060216D8 RID: 136920 RVA: 0x004A431B File Offset: 0x004A251B
		// (set) Token: 0x060216D9 RID: 136921 RVA: 0x004A4323 File Offset: 0x004A2523
		public byte NullMask { get; set; }

		// Token: 0x060216DA RID: 136922 RVA: 0x004A432C File Offset: 0x004A252C
		public IEditCustomAoiComponentT()
		{
			this.Disabled = false;
			this.Entities = null;
			this.NullMask = 0;
		}
	}
}
