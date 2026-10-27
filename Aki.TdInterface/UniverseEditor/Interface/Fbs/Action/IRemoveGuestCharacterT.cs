using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E50 RID: 28240
	public class IRemoveGuestCharacterT
	{
		// Token: 0x1700D265 RID: 53861
		// (get) Token: 0x06031E76 RID: 204406 RVA: 0x006C0A1A File Offset: 0x006BEC1A
		// (set) Token: 0x06031E77 RID: 204407 RVA: 0x006C0A22 File Offset: 0x006BEC22
		public int GuestCharacterId { get; set; }

		// Token: 0x06031E78 RID: 204408 RVA: 0x006C0A2B File Offset: 0x006BEC2B
		public IRemoveGuestCharacterT()
		{
			this.GuestCharacterId = 0;
		}
	}
}
