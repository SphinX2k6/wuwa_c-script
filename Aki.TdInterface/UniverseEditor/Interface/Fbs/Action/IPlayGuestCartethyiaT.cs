using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D18 RID: 27928
	public class IPlayGuestCartethyiaT
	{
		// Token: 0x1700CFF5 RID: 53237
		// (get) Token: 0x06031400 RID: 201728 RVA: 0x006ADFD2 File Offset: 0x006AC1D2
		// (set) Token: 0x06031401 RID: 201729 RVA: 0x006ADFDA File Offset: 0x006AC1DA
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x06031402 RID: 201730 RVA: 0x006ADFE3 File Offset: 0x006AC1E3
		public IPlayGuestCartethyiaT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
