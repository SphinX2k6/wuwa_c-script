using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007499 RID: 29849
	public class IPlayGuestUiAnimationTypeT
	{
		// Token: 0x1700DB43 RID: 56131
		// (get) Token: 0x06034420 RID: 214048 RVA: 0x00709A1A File Offset: 0x00707C1A
		// (set) Token: 0x06034421 RID: 214049 RVA: 0x00709A22 File Offset: 0x00707C22
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x06034422 RID: 214050 RVA: 0x00709A2B File Offset: 0x00707C2B
		public IPlayGuestUiAnimationTypeT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
