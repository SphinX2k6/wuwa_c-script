using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006791 RID: 26513
	public class IAddGuestCharacterT
	{
		// Token: 0x1700C0CA RID: 49354
		// (get) Token: 0x0602CF62 RID: 184162 RVA: 0x006253FF File Offset: 0x006235FF
		// (set) Token: 0x0602CF63 RID: 184163 RVA: 0x00625407 File Offset: 0x00623607
		public int GuestCharacterId { get; set; }

		// Token: 0x1700C0CB RID: 49355
		// (get) Token: 0x0602CF64 RID: 184164 RVA: 0x00625410 File Offset: 0x00623610
		// (set) Token: 0x0602CF65 RID: 184165 RVA: 0x00625418 File Offset: 0x00623618
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x0602CF66 RID: 184166 RVA: 0x00625421 File Offset: 0x00623621
		public IAddGuestCharacterT()
		{
			this.GuestCharacterId = 0;
			this.ActiveRange = null;
		}
	}
}
