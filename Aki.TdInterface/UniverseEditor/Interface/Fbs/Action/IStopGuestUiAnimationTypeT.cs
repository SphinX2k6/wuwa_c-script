using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D3 RID: 29139
	public class IStopGuestUiAnimationTypeT
	{
		// Token: 0x1700D87C RID: 55420
		// (get) Token: 0x06033B0F RID: 211727 RVA: 0x006F5C66 File Offset: 0x006F3E66
		// (set) Token: 0x06033B10 RID: 211728 RVA: 0x006F5C6E File Offset: 0x006F3E6E
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x06033B11 RID: 211729 RVA: 0x006F5C77 File Offset: 0x006F3E77
		public IStopGuestUiAnimationTypeT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
