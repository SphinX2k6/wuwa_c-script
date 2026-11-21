using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007493 RID: 29843
	public class IPlayGuestCartethyiaT
	{
		// Token: 0x1700DB3B RID: 56123
		// (get) Token: 0x060343F8 RID: 214008 RVA: 0x00709616 File Offset: 0x00707816
		// (set) Token: 0x060343F9 RID: 214009 RVA: 0x0070961E File Offset: 0x0070781E
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x060343FA RID: 214010 RVA: 0x00709627 File Offset: 0x00707827
		public IPlayGuestCartethyiaT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
