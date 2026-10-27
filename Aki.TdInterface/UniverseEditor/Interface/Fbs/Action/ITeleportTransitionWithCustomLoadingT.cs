using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B0 RID: 29616
	public class ITeleportTransitionWithCustomLoadingT
	{
		// Token: 0x1700E0D1 RID: 57553
		// (get) Token: 0x06035C41 RID: 220225 RVA: 0x0075170C File Offset: 0x0074F90C
		// (set) Token: 0x06035C42 RID: 220226 RVA: 0x00751714 File Offset: 0x0074F914
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0D2 RID: 57554
		// (get) Token: 0x06035C43 RID: 220227 RVA: 0x0075171D File Offset: 0x0074F91D
		// (set) Token: 0x06035C44 RID: 220228 RVA: 0x00751725 File Offset: 0x0074F925
		public int ConfigId { get; set; }

		// Token: 0x06035C45 RID: 220229 RVA: 0x0075172E File Offset: 0x0074F92E
		public ITeleportTransitionWithCustomLoadingT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ConfigId = 0;
		}
	}
}
