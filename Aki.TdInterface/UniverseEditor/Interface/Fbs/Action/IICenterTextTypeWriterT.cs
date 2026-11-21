using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF6 RID: 28662
	public class IICenterTextTypeWriterT
	{
		// Token: 0x1700D1F0 RID: 53744
		// (get) Token: 0x06031AAC RID: 203436 RVA: 0x006BA3E4 File Offset: 0x006B85E4
		// (set) Token: 0x06031AAD RID: 203437 RVA: 0x006BA3EC File Offset: 0x006B85EC
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x1700D1F1 RID: 53745
		// (get) Token: 0x06031AAE RID: 203438 RVA: 0x006BA3F5 File Offset: 0x006B85F5
		// (set) Token: 0x06031AAF RID: 203439 RVA: 0x006BA3FD File Offset: 0x006B85FD
		public int TextCountPerSecond { get; set; }

		// Token: 0x06031AB0 RID: 203440 RVA: 0x006BA406 File Offset: 0x006B8606
		public IICenterTextTypeWriterT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
			this.TextCountPerSecond = 0;
		}
	}
}
