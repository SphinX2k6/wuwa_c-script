using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1E RID: 27934
	public class IPlayGuestUiAnimationTypeT
	{
		// Token: 0x1700CFFD RID: 53245
		// (get) Token: 0x06031428 RID: 201768 RVA: 0x006AE3D6 File Offset: 0x006AC5D6
		// (set) Token: 0x06031429 RID: 201769 RVA: 0x006AE3DE File Offset: 0x006AC5DE
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x0603142A RID: 201770 RVA: 0x006AE3E7 File Offset: 0x006AC5E7
		public IPlayGuestUiAnimationTypeT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
