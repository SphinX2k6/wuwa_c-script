using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200639E RID: 25502
	public class IClientEventFlyingFlowerUpdateSubtitleT
	{
		// Token: 0x1700BE21 RID: 48673
		// (get) Token: 0x0602C1ED RID: 180717 RVA: 0x0060F557 File Offset: 0x0060D757
		// (set) Token: 0x0602C1EE RID: 180718 RVA: 0x0060F55F File Offset: 0x0060D75F
		public EClientEventFlyingFlowerEventType Type { get; set; }

		// Token: 0x1700BE22 RID: 48674
		// (get) Token: 0x0602C1EF RID: 180719 RVA: 0x0060F568 File Offset: 0x0060D768
		// (set) Token: 0x0602C1F0 RID: 180720 RVA: 0x0060F570 File Offset: 0x0060D770
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0602C1F1 RID: 180721 RVA: 0x0060F579 File Offset: 0x0060D779
		public IClientEventFlyingFlowerUpdateSubtitleT()
		{
			this.Type = EClientEventFlyingFlowerEventType.UpdateSubtitle;
			this.Flow = null;
		}
	}
}
