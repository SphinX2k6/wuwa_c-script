using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200612C RID: 24876
	public class IAddGuestCharacterT
	{
		// Token: 0x1700B75A RID: 46938
		// (get) Token: 0x0602A869 RID: 174185 RVA: 0x005DB223 File Offset: 0x005D9423
		// (set) Token: 0x0602A86A RID: 174186 RVA: 0x005DB22B File Offset: 0x005D942B
		public int GuestCharacterId { get; set; }

		// Token: 0x1700B75B RID: 46939
		// (get) Token: 0x0602A86B RID: 174187 RVA: 0x005DB234 File Offset: 0x005D9434
		// (set) Token: 0x0602A86C RID: 174188 RVA: 0x005DB23C File Offset: 0x005D943C
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x0602A86D RID: 174189 RVA: 0x005DB245 File Offset: 0x005D9445
		public IAddGuestCharacterT()
		{
			this.GuestCharacterId = 0;
			this.ActiveRange = null;
		}
	}
}
