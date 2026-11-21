using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CDE RID: 31966
	public class IUnlockTeleportTriggerT
	{
		// Token: 0x1700EF37 RID: 61239
		// (get) Token: 0x06039A99 RID: 236185 RVA: 0x007C75D6 File Offset: 0x007C57D6
		// (set) Token: 0x06039A9A RID: 236186 RVA: 0x007C75DE File Offset: 0x007C57DE
		public int TeleportId { get; set; }

		// Token: 0x06039A9B RID: 236187 RVA: 0x007C75E7 File Offset: 0x007C57E7
		public IUnlockTeleportTriggerT()
		{
			this.TeleportId = 0;
		}
	}
}
