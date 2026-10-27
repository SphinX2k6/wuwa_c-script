using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A7 RID: 25511
	public class IClientEventPianoSwitchPhaseT
	{
		// Token: 0x1700BE2A RID: 48682
		// (get) Token: 0x0602C221 RID: 180769 RVA: 0x0060F9D6 File Offset: 0x0060DBD6
		// (set) Token: 0x0602C222 RID: 180770 RVA: 0x0060F9DE File Offset: 0x0060DBDE
		public EClientEventPianoEventType Type { get; set; }

		// Token: 0x0602C223 RID: 180771 RVA: 0x0060F9E7 File Offset: 0x0060DBE7
		public IClientEventPianoSwitchPhaseT()
		{
			this.Type = EClientEventPianoEventType.UpdateSubtitle;
		}
	}
}
