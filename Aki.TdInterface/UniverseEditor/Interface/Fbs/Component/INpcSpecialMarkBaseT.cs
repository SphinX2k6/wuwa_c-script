using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564E RID: 22094
	public class INpcSpecialMarkBaseT
	{
		// Token: 0x1700A3A9 RID: 41897
		// (get) Token: 0x06024BB3 RID: 150451 RVA: 0x005118CE File Offset: 0x0050FACE
		// (set) Token: 0x06024BB4 RID: 150452 RVA: 0x005118D6 File Offset: 0x0050FAD6
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x06024BB5 RID: 150453 RVA: 0x005118DF File Offset: 0x0050FADF
		public INpcSpecialMarkBaseT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
		}
	}
}
