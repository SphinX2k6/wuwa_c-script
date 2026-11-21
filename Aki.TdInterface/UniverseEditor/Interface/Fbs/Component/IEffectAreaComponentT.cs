using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005671 RID: 22129
	public class IEffectAreaComponentT
	{
		// Token: 0x17009F1D RID: 40733
		// (get) Token: 0x06023642 RID: 144962 RVA: 0x004DE579 File Offset: 0x004DC779
		// (set) Token: 0x06023643 RID: 144963 RVA: 0x004DE581 File Offset: 0x004DC781
		public bool Disabled { get; set; }

		// Token: 0x17009F1E RID: 40734
		// (get) Token: 0x06023644 RID: 144964 RVA: 0x004DE58A File Offset: 0x004DC78A
		// (set) Token: 0x06023645 RID: 144965 RVA: 0x004DE592 File Offset: 0x004DC792
		public IBuffAreaT Config { get; set; }

		// Token: 0x17009F1F RID: 40735
		// (get) Token: 0x06023646 RID: 144966 RVA: 0x004DE59B File Offset: 0x004DC79B
		// (set) Token: 0x06023647 RID: 144967 RVA: 0x004DE5A3 File Offset: 0x004DC7A3
		public byte NullMask { get; set; }

		// Token: 0x06023648 RID: 144968 RVA: 0x004DE5AC File Offset: 0x004DC7AC
		public IEffectAreaComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
