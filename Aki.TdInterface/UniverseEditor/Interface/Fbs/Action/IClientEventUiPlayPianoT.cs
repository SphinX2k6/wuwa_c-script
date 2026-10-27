using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B9 RID: 25529
	public class IClientEventUiPlayPianoT
	{
		// Token: 0x1700BE42 RID: 48706
		// (get) Token: 0x0602C29B RID: 180891 RVA: 0x006106DB File Offset: 0x0060E8DB
		// (set) Token: 0x0602C29C RID: 180892 RVA: 0x006106E3 File Offset: 0x0060E8E3
		public EClientEventUiType Type { get; set; }

		// Token: 0x1700BE43 RID: 48707
		// (get) Token: 0x0602C29D RID: 180893 RVA: 0x006106EC File Offset: 0x0060E8EC
		// (set) Token: 0x0602C29E RID: 180894 RVA: 0x006106F4 File Offset: 0x0060E8F4
		public TClientEventPianoEventUnion EventType { get; set; }

		// Token: 0x0602C29F RID: 180895 RVA: 0x006106FD File Offset: 0x0060E8FD
		public IClientEventUiPlayPianoT()
		{
			this.Type = EClientEventUiType.PlayPiano;
			this.EventType = null;
		}
	}
}
