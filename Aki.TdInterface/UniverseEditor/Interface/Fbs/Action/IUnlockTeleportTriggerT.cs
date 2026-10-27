using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E8 RID: 29928
	public class IUnlockTeleportTriggerT
	{
		// Token: 0x1700E30D RID: 58125
		// (get) Token: 0x06036684 RID: 222852 RVA: 0x00764386 File Offset: 0x00762586
		// (set) Token: 0x06036685 RID: 222853 RVA: 0x0076438E File Offset: 0x0076258E
		public int TeleportId { get; set; }

		// Token: 0x06036686 RID: 222854 RVA: 0x00764397 File Offset: 0x00762597
		public IUnlockTeleportTriggerT()
		{
			this.TeleportId = 0;
		}
	}
}
