using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B91 RID: 31633
	public class ITeleportTransitionWithCenterTextT
	{
		// Token: 0x1700ECD7 RID: 60631
		// (get) Token: 0x06038FB0 RID: 233392 RVA: 0x007B382B File Offset: 0x007B1A2B
		// (set) Token: 0x06038FB1 RID: 233393 RVA: 0x007B3833 File Offset: 0x007B1A33
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECD8 RID: 60632
		// (get) Token: 0x06038FB2 RID: 233394 RVA: 0x007B383C File Offset: 0x007B1A3C
		// (set) Token: 0x06038FB3 RID: 233395 RVA: 0x007B3844 File Offset: 0x007B1A44
		public IPlayFlowT CenterTextFlow { get; set; }

		// Token: 0x06038FB4 RID: 233396 RVA: 0x007B384D File Offset: 0x007B1A4D
		public ITeleportTransitionWithCenterTextT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.CenterTextFlow = null;
		}
	}
}
