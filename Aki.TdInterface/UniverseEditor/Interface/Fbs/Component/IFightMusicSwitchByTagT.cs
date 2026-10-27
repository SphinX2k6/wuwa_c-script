using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200524D RID: 21069
	public class IFightMusicSwitchByTagT
	{
		// Token: 0x17009A5A RID: 39514
		// (get) Token: 0x06022463 RID: 140387 RVA: 0x004C0D0E File Offset: 0x004BEF0E
		// (set) Token: 0x06022464 RID: 140388 RVA: 0x004C0D16 File Offset: 0x004BEF16
		public string FightMusic { get; set; }

		// Token: 0x17009A5B RID: 39515
		// (get) Token: 0x06022465 RID: 140389 RVA: 0x004C0D1F File Offset: 0x004BEF1F
		// (set) Token: 0x06022466 RID: 140390 RVA: 0x004C0D27 File Offset: 0x004BEF27
		public string ActivateTag { get; set; }

		// Token: 0x06022467 RID: 140391 RVA: 0x004C0D30 File Offset: 0x004BEF30
		public IFightMusicSwitchByTagT()
		{
			this.FightMusic = null;
			this.ActivateTag = null;
		}
	}
}
