using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2A RID: 27178
	public class IClientEventUiPlayPianoT
	{
		// Token: 0x1700C7C6 RID: 51142
		// (get) Token: 0x0602E9FD RID: 190973 RVA: 0x0065B713 File Offset: 0x00659913
		// (set) Token: 0x0602E9FE RID: 190974 RVA: 0x0065B71B File Offset: 0x0065991B
		public EClientEventUiType Type { get; set; }

		// Token: 0x1700C7C7 RID: 51143
		// (get) Token: 0x0602E9FF RID: 190975 RVA: 0x0065B724 File Offset: 0x00659924
		// (set) Token: 0x0602EA00 RID: 190976 RVA: 0x0065B72C File Offset: 0x0065992C
		public TClientEventPianoEventUnion EventType { get; set; }

		// Token: 0x0602EA01 RID: 190977 RVA: 0x0065B735 File Offset: 0x00659935
		public IClientEventUiPlayPianoT()
		{
			this.Type = EClientEventUiType.PlayPiano;
			this.EventType = null;
		}
	}
}
