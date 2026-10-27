using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005657 RID: 22103
	public class INpcSpecialMarkTrafficLightT
	{
		// Token: 0x1700A3B1 RID: 41905
		// (get) Token: 0x06024BE5 RID: 150501 RVA: 0x00511D06 File Offset: 0x0050FF06
		// (set) Token: 0x06024BE6 RID: 150502 RVA: 0x00511D0E File Offset: 0x0050FF0E
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x06024BE7 RID: 150503 RVA: 0x00511D17 File Offset: 0x0050FF17
		public INpcSpecialMarkTrafficLightT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
		}
	}
}
