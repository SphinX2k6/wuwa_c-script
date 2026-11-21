using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005710 RID: 22288
	public class IEntityPackageNodeT
	{
		// Token: 0x1700A0B7 RID: 41143
		// (get) Token: 0x06023CCB RID: 146635 RVA: 0x004EBC49 File Offset: 0x004E9E49
		// (set) Token: 0x06023CCC RID: 146636 RVA: 0x004EBC51 File Offset: 0x004E9E51
		public int EntityId { get; set; }

		// Token: 0x1700A0B8 RID: 41144
		// (get) Token: 0x06023CCD RID: 146637 RVA: 0x004EBC5A File Offset: 0x004E9E5A
		// (set) Token: 0x06023CCE RID: 146638 RVA: 0x004EBC62 File Offset: 0x004E9E62
		public List<IEntityPackageNodeT> Children { get; set; }

		// Token: 0x1700A0B9 RID: 41145
		// (get) Token: 0x06023CCF RID: 146639 RVA: 0x004EBC6B File Offset: 0x004E9E6B
		// (set) Token: 0x06023CD0 RID: 146640 RVA: 0x004EBC73 File Offset: 0x004E9E73
		public byte NullMask { get; set; }

		// Token: 0x06023CD1 RID: 146641 RVA: 0x004EBC7C File Offset: 0x004E9E7C
		public IEntityPackageNodeT()
		{
			this.EntityId = 0;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}
