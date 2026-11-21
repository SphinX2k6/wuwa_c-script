using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D1 RID: 30161
	public class IRemoveGuestCharacterT
	{
		// Token: 0x1700DDB7 RID: 56759
		// (get) Token: 0x06034E9E RID: 216734 RVA: 0x0071C51A File Offset: 0x0071A71A
		// (set) Token: 0x06034E9F RID: 216735 RVA: 0x0071C522 File Offset: 0x0071A722
		public int GuestCharacterId { get; set; }

		// Token: 0x06034EA0 RID: 216736 RVA: 0x0071C52B File Offset: 0x0071A72B
		public IRemoveGuestCharacterT()
		{
			this.GuestCharacterId = 0;
		}
	}
}
