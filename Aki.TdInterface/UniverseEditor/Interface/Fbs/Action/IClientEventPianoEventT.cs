using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A1 RID: 25505
	public class IClientEventPianoEventT
	{
		// Token: 0x1700BE25 RID: 48677
		// (get) Token: 0x0602C201 RID: 180737 RVA: 0x0060F716 File Offset: 0x0060D916
		// (set) Token: 0x0602C202 RID: 180738 RVA: 0x0060F71E File Offset: 0x0060D91E
		public EClientEventPianoEventType Type { get; set; }

		// Token: 0x0602C203 RID: 180739 RVA: 0x0060F727 File Offset: 0x0060D927
		public IClientEventPianoEventT()
		{
			this.Type = EClientEventPianoEventType.UpdateSubtitle;
		}
	}
}
