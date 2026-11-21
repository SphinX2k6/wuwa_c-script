using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A93 RID: 19091
	public class IActivateTeleportT
	{
		// Token: 0x170085C0 RID: 34240
		// (get) Token: 0x0601CB20 RID: 117536 RVA: 0x0040BE38 File Offset: 0x0040A038
		// (set) Token: 0x0601CB21 RID: 117537 RVA: 0x0040BE40 File Offset: 0x0040A040
		public EGmCommand Type { get; set; }

		// Token: 0x170085C1 RID: 34241
		// (get) Token: 0x0601CB22 RID: 117538 RVA: 0x0040BE49 File Offset: 0x0040A049
		// (set) Token: 0x0601CB23 RID: 117539 RVA: 0x0040BE51 File Offset: 0x0040A051
		public int TeleportId { get; set; }

		// Token: 0x0601CB24 RID: 117540 RVA: 0x0040BE5A File Offset: 0x0040A05A
		public IActivateTeleportT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.TeleportId = 0;
		}
	}
}
