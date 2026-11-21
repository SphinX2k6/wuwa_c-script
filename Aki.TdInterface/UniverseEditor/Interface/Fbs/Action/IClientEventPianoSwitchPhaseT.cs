using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A18 RID: 27160
	public class IClientEventPianoSwitchPhaseT
	{
		// Token: 0x1700C7AE RID: 51118
		// (get) Token: 0x0602E983 RID: 190851 RVA: 0x0065AA0E File Offset: 0x00658C0E
		// (set) Token: 0x0602E984 RID: 190852 RVA: 0x0065AA16 File Offset: 0x00658C16
		public EClientEventPianoEventType Type { get; set; }

		// Token: 0x0602E985 RID: 190853 RVA: 0x0065AA1F File Offset: 0x00658C1F
		public IClientEventPianoSwitchPhaseT()
		{
			this.Type = EClientEventPianoEventType.UpdateSubtitle;
		}
	}
}
