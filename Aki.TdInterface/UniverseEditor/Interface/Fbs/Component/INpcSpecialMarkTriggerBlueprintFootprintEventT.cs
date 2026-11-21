using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF8 RID: 23544
	public class INpcSpecialMarkTriggerBlueprintFootprintEventT
	{
		// Token: 0x1700AC3F RID: 44095
		// (get) Token: 0x06026E1C RID: 159260 RVA: 0x0055287F File Offset: 0x00550A7F
		// (set) Token: 0x06026E1D RID: 159261 RVA: 0x00552887 File Offset: 0x00550A87
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x1700AC40 RID: 44096
		// (get) Token: 0x06026E1E RID: 159262 RVA: 0x00552890 File Offset: 0x00550A90
		// (set) Token: 0x06026E1F RID: 159263 RVA: 0x00552898 File Offset: 0x00550A98
		public string ConfigDa { get; set; }

		// Token: 0x06026E20 RID: 159264 RVA: 0x005528A1 File Offset: 0x00550AA1
		public INpcSpecialMarkTriggerBlueprintFootprintEventT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
			this.ConfigDa = null;
		}
	}
}
