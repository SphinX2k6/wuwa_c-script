using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574C RID: 22348
	public class IPointAkEventT
	{
		// Token: 0x1700A6BD RID: 42685
		// (get) Token: 0x06025737 RID: 153399 RVA: 0x0052AFA9 File Offset: 0x005291A9
		// (set) Token: 0x06025738 RID: 153400 RVA: 0x0052AFB1 File Offset: 0x005291B1
		public EAkEventType Type { get; set; }

		// Token: 0x1700A6BE RID: 42686
		// (get) Token: 0x06025739 RID: 153401 RVA: 0x0052AFBA File Offset: 0x005291BA
		// (set) Token: 0x0602573A RID: 153402 RVA: 0x0052AFC2 File Offset: 0x005291C2
		public List<int> PointIds { get; set; }

		// Token: 0x1700A6BF RID: 42687
		// (get) Token: 0x0602573B RID: 153403 RVA: 0x0052AFCB File Offset: 0x005291CB
		// (set) Token: 0x0602573C RID: 153404 RVA: 0x0052AFD3 File Offset: 0x005291D3
		public bool UseListenerCone { get; set; }

		// Token: 0x1700A6C0 RID: 42688
		// (get) Token: 0x0602573D RID: 153405 RVA: 0x0052AFDC File Offset: 0x005291DC
		// (set) Token: 0x0602573E RID: 153406 RVA: 0x0052AFE4 File Offset: 0x005291E4
		public bool EnableOcclusion { get; set; }

		// Token: 0x1700A6C1 RID: 42689
		// (get) Token: 0x0602573F RID: 153407 RVA: 0x0052AFED File Offset: 0x005291ED
		// (set) Token: 0x06025740 RID: 153408 RVA: 0x0052AFF5 File Offset: 0x005291F5
		public byte NullMask { get; set; }

		// Token: 0x06025741 RID: 153409 RVA: 0x0052AFFE File Offset: 0x005291FE
		public IPointAkEventT()
		{
			this.Type = EAkEventType.Point;
			this.PointIds = null;
			this.UseListenerCone = false;
			this.EnableOcclusion = false;
			this.NullMask = 0;
		}
	}
}
