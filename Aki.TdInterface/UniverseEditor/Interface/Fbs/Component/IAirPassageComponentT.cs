using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005398 RID: 21400
	public class IAirPassageComponentT
	{
		// Token: 0x17009749 RID: 38729
		// (get) Token: 0x06021617 RID: 136727 RVA: 0x0049B2C4 File Offset: 0x004994C4
		// (set) Token: 0x06021618 RID: 136728 RVA: 0x0049B2CC File Offset: 0x004994CC
		public bool Disabled { get; set; }

		// Token: 0x1700974A RID: 38730
		// (get) Token: 0x06021619 RID: 136729 RVA: 0x0049B2D5 File Offset: 0x004994D5
		// (set) Token: 0x0602161A RID: 136730 RVA: 0x0049B2DD File Offset: 0x004994DD
		public byte NullMask { get; set; }

		// Token: 0x0602161B RID: 136731 RVA: 0x0049B2E6 File Offset: 0x004994E6
		public IAirPassageComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
