using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B5E RID: 31582
	public class ITeleportConfigT
	{
		// Token: 0x1700EC75 RID: 60533
		// (get) Token: 0x06038DF3 RID: 232947 RVA: 0x007B03F2 File Offset: 0x007AE5F2
		// (set) Token: 0x06038DF4 RID: 232948 RVA: 0x007B03FA File Offset: 0x007AE5FA
		public ETeleportType Type { get; set; }

		// Token: 0x06038DF5 RID: 232949 RVA: 0x007B0403 File Offset: 0x007AE603
		public ITeleportConfigT()
		{
			this.Type = ETeleportType.FixedPos;
		}
	}
}
