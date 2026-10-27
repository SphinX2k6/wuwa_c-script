using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CD RID: 29133
	public class IStopGuestCartethyiaT
	{
		// Token: 0x1700D874 RID: 55412
		// (get) Token: 0x06033AE7 RID: 211687 RVA: 0x006F5862 File Offset: 0x006F3A62
		// (set) Token: 0x06033AE8 RID: 211688 RVA: 0x006F586A File Offset: 0x006F3A6A
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x06033AE9 RID: 211689 RVA: 0x006F5873 File Offset: 0x006F3A73
		public IStopGuestCartethyiaT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
