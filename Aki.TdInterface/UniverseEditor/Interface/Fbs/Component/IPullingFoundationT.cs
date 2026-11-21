using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB6 RID: 23990
	public class IPullingFoundationT
	{
		// Token: 0x1700B0B9 RID: 45241
		// (get) Token: 0x06027FEE RID: 163822 RVA: 0x0057887D File Offset: 0x00576A7D
		// (set) Token: 0x06027FEF RID: 163823 RVA: 0x00578885 File Offset: 0x00576A85
		public bool Disabled { get; set; }

		// Token: 0x1700B0BA RID: 45242
		// (get) Token: 0x06027FF0 RID: 163824 RVA: 0x0057888E File Offset: 0x00576A8E
		// (set) Token: 0x06027FF1 RID: 163825 RVA: 0x00578896 File Offset: 0x00576A96
		public IPullingCategoryMatchingFoundationT Config { get; set; }

		// Token: 0x1700B0BB RID: 45243
		// (get) Token: 0x06027FF2 RID: 163826 RVA: 0x0057889F File Offset: 0x00576A9F
		// (set) Token: 0x06027FF3 RID: 163827 RVA: 0x005788A7 File Offset: 0x00576AA7
		public byte NullMask { get; set; }

		// Token: 0x06027FF4 RID: 163828 RVA: 0x005788B0 File Offset: 0x00576AB0
		public IPullingFoundationT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
