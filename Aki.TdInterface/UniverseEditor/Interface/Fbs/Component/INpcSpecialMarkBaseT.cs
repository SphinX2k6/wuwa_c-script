using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEC RID: 23532
	public class INpcSpecialMarkBaseT
	{
		// Token: 0x1700AC33 RID: 44083
		// (get) Token: 0x06026DD2 RID: 159186 RVA: 0x005521F2 File Offset: 0x005503F2
		// (set) Token: 0x06026DD3 RID: 159187 RVA: 0x005521FA File Offset: 0x005503FA
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x06026DD4 RID: 159188 RVA: 0x00552203 File Offset: 0x00550403
		public INpcSpecialMarkBaseT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
		}
	}
}
