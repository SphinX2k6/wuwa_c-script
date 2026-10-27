using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C7 RID: 29895
	public class IUnlockCookSystemCookBookT
	{
		// Token: 0x1700E2E7 RID: 58087
		// (get) Token: 0x060365A5 RID: 222629 RVA: 0x00762D3C File Offset: 0x00760F3C
		// (set) Token: 0x060365A6 RID: 222630 RVA: 0x00762D44 File Offset: 0x00760F44
		public EUnlockCookSystemType Type { get; set; }

		// Token: 0x1700E2E8 RID: 58088
		// (get) Token: 0x060365A7 RID: 222631 RVA: 0x00762D4D File Offset: 0x00760F4D
		// (set) Token: 0x060365A8 RID: 222632 RVA: 0x00762D55 File Offset: 0x00760F55
		public int CookBookId { get; set; }

		// Token: 0x060365A9 RID: 222633 RVA: 0x00762D5E File Offset: 0x00760F5E
		public IUnlockCookSystemCookBookT()
		{
			this.Type = EUnlockCookSystemType.UnlockCookBook;
			this.CookBookId = 0;
		}
	}
}
