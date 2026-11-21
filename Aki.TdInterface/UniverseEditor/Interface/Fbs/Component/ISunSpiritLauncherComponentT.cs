using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006018 RID: 24600
	public class ISunSpiritLauncherComponentT
	{
		// Token: 0x1700B66F RID: 46703
		// (get) Token: 0x06029796 RID: 169878 RVA: 0x005A91DE File Offset: 0x005A73DE
		// (set) Token: 0x06029797 RID: 169879 RVA: 0x005A91E6 File Offset: 0x005A73E6
		public bool Disabled { get; set; }

		// Token: 0x1700B670 RID: 46704
		// (get) Token: 0x06029798 RID: 169880 RVA: 0x005A91EF File Offset: 0x005A73EF
		// (set) Token: 0x06029799 RID: 169881 RVA: 0x005A91F7 File Offset: 0x005A73F7
		public int AreaId { get; set; }

		// Token: 0x1700B671 RID: 46705
		// (get) Token: 0x0602979A RID: 169882 RVA: 0x005A9200 File Offset: 0x005A7400
		// (set) Token: 0x0602979B RID: 169883 RVA: 0x005A9208 File Offset: 0x005A7408
		public int NeedsCount { get; set; }

		// Token: 0x1700B672 RID: 46706
		// (get) Token: 0x0602979C RID: 169884 RVA: 0x005A9211 File Offset: 0x005A7411
		// (set) Token: 0x0602979D RID: 169885 RVA: 0x005A9219 File Offset: 0x005A7419
		public int SunSpiritGearId { get; set; }

		// Token: 0x1700B673 RID: 46707
		// (get) Token: 0x0602979E RID: 169886 RVA: 0x005A9222 File Offset: 0x005A7422
		// (set) Token: 0x0602979F RID: 169887 RVA: 0x005A922A File Offset: 0x005A742A
		public byte NullMask { get; set; }

		// Token: 0x060297A0 RID: 169888 RVA: 0x005A9233 File Offset: 0x005A7433
		public ISunSpiritLauncherComponentT()
		{
			this.Disabled = false;
			this.AreaId = 0;
			this.NeedsCount = 0;
			this.SunSpiritGearId = 0;
			this.NullMask = 0;
		}
	}
}
