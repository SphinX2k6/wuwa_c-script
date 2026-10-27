using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006318 RID: 25368
	public class IChangePhantomFormationT
	{
		// Token: 0x1700BD60 RID: 48480
		// (get) Token: 0x0602BE0B RID: 179723 RVA: 0x006088ED File Offset: 0x00606AED
		// (set) Token: 0x0602BE0C RID: 179724 RVA: 0x006088F5 File Offset: 0x00606AF5
		public int FormationId { get; set; }

		// Token: 0x1700BD61 RID: 48481
		// (get) Token: 0x0602BE0D RID: 179725 RVA: 0x006088FE File Offset: 0x00606AFE
		// (set) Token: 0x0602BE0E RID: 179726 RVA: 0x00608906 File Offset: 0x00606B06
		public bool RetainRole { get; set; }

		// Token: 0x1700BD62 RID: 48482
		// (get) Token: 0x0602BE0F RID: 179727 RVA: 0x0060890F File Offset: 0x00606B0F
		// (set) Token: 0x0602BE10 RID: 179728 RVA: 0x00608917 File Offset: 0x00606B17
		public int TeleportEntityId { get; set; }

		// Token: 0x1700BD63 RID: 48483
		// (get) Token: 0x0602BE11 RID: 179729 RVA: 0x00608920 File Offset: 0x00606B20
		// (set) Token: 0x0602BE12 RID: 179730 RVA: 0x00608928 File Offset: 0x00606B28
		public List<long> AppendBuffIds { get; set; }

		// Token: 0x1700BD64 RID: 48484
		// (get) Token: 0x0602BE13 RID: 179731 RVA: 0x00608931 File Offset: 0x00606B31
		// (set) Token: 0x0602BE14 RID: 179732 RVA: 0x00608939 File Offset: 0x00606B39
		public byte NullMask { get; set; }

		// Token: 0x0602BE15 RID: 179733 RVA: 0x00608942 File Offset: 0x00606B42
		public IChangePhantomFormationT()
		{
			this.FormationId = 0;
			this.RetainRole = false;
			this.TeleportEntityId = 0;
			this.AppendBuffIds = null;
			this.NullMask = 0;
		}
	}
}
