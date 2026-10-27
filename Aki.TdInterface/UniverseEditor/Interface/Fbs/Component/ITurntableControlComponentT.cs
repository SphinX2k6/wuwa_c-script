using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF4 RID: 23284
	public class ITurntableControlComponentT
	{
		// Token: 0x1700AFA9 RID: 44969
		// (get) Token: 0x06027C02 RID: 162818 RVA: 0x00577CD5 File Offset: 0x00575ED5
		// (set) Token: 0x06027C03 RID: 162819 RVA: 0x00577CDD File Offset: 0x00575EDD
		public bool Disabled { get; set; }

		// Token: 0x1700AFAA RID: 44970
		// (get) Token: 0x06027C04 RID: 162820 RVA: 0x00577CE6 File Offset: 0x00575EE6
		// (set) Token: 0x06027C05 RID: 162821 RVA: 0x00577CEE File Offset: 0x00575EEE
		public TTurntableControllerUnion Config { get; set; }

		// Token: 0x1700AFAB RID: 44971
		// (get) Token: 0x06027C06 RID: 162822 RVA: 0x00577CF7 File Offset: 0x00575EF7
		// (set) Token: 0x06027C07 RID: 162823 RVA: 0x00577CFF File Offset: 0x00575EFF
		public byte NullMask { get; set; }

		// Token: 0x06027C08 RID: 162824 RVA: 0x00577D08 File Offset: 0x00575F08
		public ITurntableControlComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
