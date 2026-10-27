using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B04 RID: 27396
	public class IMontageRegisteredT
	{
		// Token: 0x1700CB67 RID: 52071
		// (get) Token: 0x060300C8 RID: 196808 RVA: 0x006884FF File Offset: 0x006866FF
		// (set) Token: 0x060300C9 RID: 196809 RVA: 0x00688507 File Offset: 0x00686707
		public EMontageConfigType Type { get; set; }

		// Token: 0x1700CB68 RID: 52072
		// (get) Token: 0x060300CA RID: 196810 RVA: 0x00688510 File Offset: 0x00686710
		// (set) Token: 0x060300CB RID: 196811 RVA: 0x00688518 File Offset: 0x00686718
		public IMontageIdT MontageId { get; set; }

		// Token: 0x060300CC RID: 196812 RVA: 0x00688521 File Offset: 0x00686721
		public IMontageRegisteredT()
		{
			this.Type = EMontageConfigType.Asset;
			this.MontageId = null;
		}
	}
}
