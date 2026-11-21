using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A2 RID: 31138
	public class IStopGuestCartethyiaT
	{
		// Token: 0x1700E46D RID: 58477
		// (get) Token: 0x06036DE9 RID: 224745 RVA: 0x00756BC2 File Offset: 0x00754DC2
		// (set) Token: 0x06036DEA RID: 224746 RVA: 0x00756BCA File Offset: 0x00754DCA
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x06036DEB RID: 224747 RVA: 0x00756BD3 File Offset: 0x00754DD3
		public IStopGuestCartethyiaT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
