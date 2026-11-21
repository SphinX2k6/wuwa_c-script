using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF5 RID: 23541
	public class INpcSpecialMarkTrafficLightT
	{
		// Token: 0x1700AC3B RID: 44091
		// (get) Token: 0x06026E06 RID: 159238 RVA: 0x0055266E File Offset: 0x0055086E
		// (set) Token: 0x06026E07 RID: 159239 RVA: 0x00552676 File Offset: 0x00550876
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x06026E08 RID: 159240 RVA: 0x0055267F File Offset: 0x0055087F
		public INpcSpecialMarkTrafficLightT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
		}
	}
}
