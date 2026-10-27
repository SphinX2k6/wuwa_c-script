using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738F RID: 29583
	public class ITeleportToLatestResetPointDirectlyT
	{
		// Token: 0x1700E094 RID: 57492
		// (get) Token: 0x06035B2D RID: 219949 RVA: 0x0074F90A File Offset: 0x0074DB0A
		// (set) Token: 0x06035B2E RID: 219950 RVA: 0x0074F912 File Offset: 0x0074DB12
		public ETeleportToLatestResetPointType Type { get; set; }

		// Token: 0x06035B2F RID: 219951 RVA: 0x0074F91B File Offset: 0x0074DB1B
		public ITeleportToLatestResetPointDirectlyT()
		{
			this.Type = ETeleportToLatestResetPointType.Directly;
		}
	}
}
