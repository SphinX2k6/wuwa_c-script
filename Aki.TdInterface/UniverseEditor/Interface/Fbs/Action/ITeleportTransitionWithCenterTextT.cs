using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AA RID: 29610
	public class ITeleportTransitionWithCenterTextT
	{
		// Token: 0x1700E0C7 RID: 57543
		// (get) Token: 0x06035C15 RID: 220181 RVA: 0x007512EB File Offset: 0x0074F4EB
		// (set) Token: 0x06035C16 RID: 220182 RVA: 0x007512F3 File Offset: 0x0074F4F3
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0C8 RID: 57544
		// (get) Token: 0x06035C17 RID: 220183 RVA: 0x007512FC File Offset: 0x0074F4FC
		// (set) Token: 0x06035C18 RID: 220184 RVA: 0x00751304 File Offset: 0x0074F504
		public IPlayFlowT CenterTextFlow { get; set; }

		// Token: 0x06035C19 RID: 220185 RVA: 0x0075130D File Offset: 0x0074F50D
		public ITeleportTransitionWithCenterTextT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.CenterTextFlow = null;
		}
	}
}
