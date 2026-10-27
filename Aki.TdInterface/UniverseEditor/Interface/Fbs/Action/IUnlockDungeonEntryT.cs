using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D6 RID: 29910
	public class IUnlockDungeonEntryT
	{
		// Token: 0x1700E2FA RID: 58106
		// (get) Token: 0x06036603 RID: 222723 RVA: 0x007635DA File Offset: 0x007617DA
		// (set) Token: 0x06036604 RID: 222724 RVA: 0x007635E2 File Offset: 0x007617E2
		public int DungeonEntryId { get; set; }

		// Token: 0x06036605 RID: 222725 RVA: 0x007635EB File Offset: 0x007617EB
		public IUnlockDungeonEntryT()
		{
			this.DungeonEntryId = 0;
		}
	}
}
