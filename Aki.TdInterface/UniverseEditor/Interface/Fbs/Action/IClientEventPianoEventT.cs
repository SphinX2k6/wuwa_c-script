using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A12 RID: 27154
	public class IClientEventPianoEventT
	{
		// Token: 0x1700C7A9 RID: 51113
		// (get) Token: 0x0602E963 RID: 190819 RVA: 0x0065A74E File Offset: 0x0065894E
		// (set) Token: 0x0602E964 RID: 190820 RVA: 0x0065A756 File Offset: 0x00658956
		public EClientEventPianoEventType Type { get; set; }

		// Token: 0x0602E965 RID: 190821 RVA: 0x0065A75F File Offset: 0x0065895F
		public IClientEventPianoEventT()
		{
			this.Type = EClientEventPianoEventType.UpdateSubtitle;
		}
	}
}
