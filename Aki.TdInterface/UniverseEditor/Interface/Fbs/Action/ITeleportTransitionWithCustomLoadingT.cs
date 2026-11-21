using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B97 RID: 31639
	public class ITeleportTransitionWithCustomLoadingT
	{
		// Token: 0x1700ECE1 RID: 60641
		// (get) Token: 0x06038FDC RID: 233436 RVA: 0x007B3C4C File Offset: 0x007B1E4C
		// (set) Token: 0x06038FDD RID: 233437 RVA: 0x007B3C54 File Offset: 0x007B1E54
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECE2 RID: 60642
		// (get) Token: 0x06038FDE RID: 233438 RVA: 0x007B3C5D File Offset: 0x007B1E5D
		// (set) Token: 0x06038FDF RID: 233439 RVA: 0x007B3C65 File Offset: 0x007B1E65
		public int ConfigId { get; set; }

		// Token: 0x06038FE0 RID: 233440 RVA: 0x007B3C6E File Offset: 0x007B1E6E
		public ITeleportTransitionWithCustomLoadingT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ConfigId = 0;
		}
	}
}
