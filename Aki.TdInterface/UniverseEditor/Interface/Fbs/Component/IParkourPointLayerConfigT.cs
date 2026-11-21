using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C55 RID: 23637
	public class IParkourPointLayerConfigT
	{
		// Token: 0x1700ADA2 RID: 44450
		// (get) Token: 0x06027315 RID: 160533 RVA: 0x0055E630 File Offset: 0x0055C830
		// (set) Token: 0x06027316 RID: 160534 RVA: 0x0055E638 File Offset: 0x0055C838
		public int Width { get; set; }

		// Token: 0x1700ADA3 RID: 44451
		// (get) Token: 0x06027317 RID: 160535 RVA: 0x0055E641 File Offset: 0x0055C841
		// (set) Token: 0x06027318 RID: 160536 RVA: 0x0055E649 File Offset: 0x0055C849
		public int Length { get; set; }

		// Token: 0x06027319 RID: 160537 RVA: 0x0055E652 File Offset: 0x0055C852
		public IParkourPointLayerConfigT()
		{
			this.Width = 0;
			this.Length = 0;
		}
	}
}
