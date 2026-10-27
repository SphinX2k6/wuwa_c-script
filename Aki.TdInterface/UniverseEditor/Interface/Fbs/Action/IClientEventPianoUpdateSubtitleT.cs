using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063AA RID: 25514
	public class IClientEventPianoUpdateSubtitleT
	{
		// Token: 0x1700BE2F RID: 48687
		// (get) Token: 0x0602C237 RID: 180791 RVA: 0x0060FC81 File Offset: 0x0060DE81
		// (set) Token: 0x0602C238 RID: 180792 RVA: 0x0060FC89 File Offset: 0x0060DE89
		public EClientEventPianoEventType Type { get; set; }

		// Token: 0x1700BE30 RID: 48688
		// (get) Token: 0x0602C239 RID: 180793 RVA: 0x0060FC92 File Offset: 0x0060DE92
		// (set) Token: 0x0602C23A RID: 180794 RVA: 0x0060FC9A File Offset: 0x0060DE9A
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700BE31 RID: 48689
		// (get) Token: 0x0602C23B RID: 180795 RVA: 0x0060FCA3 File Offset: 0x0060DEA3
		// (set) Token: 0x0602C23C RID: 180796 RVA: 0x0060FCAB File Offset: 0x0060DEAB
		public bool DisableMove { get; set; }

		// Token: 0x0602C23D RID: 180797 RVA: 0x0060FCB4 File Offset: 0x0060DEB4
		public IClientEventPianoUpdateSubtitleT()
		{
			this.Type = EClientEventPianoEventType.UpdateSubtitle;
			this.Flow = null;
			this.DisableMove = false;
		}
	}
}
