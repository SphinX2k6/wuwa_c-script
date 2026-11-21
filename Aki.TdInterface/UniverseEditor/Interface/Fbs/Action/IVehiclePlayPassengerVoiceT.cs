using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D23 RID: 32035
	public class IVehiclePlayPassengerVoiceT
	{
		// Token: 0x1700EFD0 RID: 61392
		// (get) Token: 0x06039D57 RID: 236887 RVA: 0x007CD890 File Offset: 0x007CBA90
		// (set) Token: 0x06039D58 RID: 236888 RVA: 0x007CD898 File Offset: 0x007CBA98
		public EGondolaVoiceTriggeredType TriggerType { get; set; }

		// Token: 0x1700EFD1 RID: 61393
		// (get) Token: 0x06039D59 RID: 236889 RVA: 0x007CD8A1 File Offset: 0x007CBAA1
		// (set) Token: 0x06039D5A RID: 236890 RVA: 0x007CD8A9 File Offset: 0x007CBAA9
		public IPlayVoicePassengersConfigT TriggerPassengers { get; set; }

		// Token: 0x1700EFD2 RID: 61394
		// (get) Token: 0x06039D5B RID: 236891 RVA: 0x007CD8B2 File Offset: 0x007CBAB2
		// (set) Token: 0x06039D5C RID: 236892 RVA: 0x007CD8BA File Offset: 0x007CBABA
		public List<float> TriggerParams { get; set; }

		// Token: 0x1700EFD3 RID: 61395
		// (get) Token: 0x06039D5D RID: 236893 RVA: 0x007CD8C3 File Offset: 0x007CBAC3
		// (set) Token: 0x06039D5E RID: 236894 RVA: 0x007CD8CB File Offset: 0x007CBACB
		public byte NullMask { get; set; }

		// Token: 0x06039D5F RID: 236895 RVA: 0x007CD8D4 File Offset: 0x007CBAD4
		public IVehiclePlayPassengerVoiceT()
		{
			this.TriggerType = EGondolaVoiceTriggeredType.FindTreasure;
			this.TriggerPassengers = null;
			this.TriggerParams = null;
			this.NullMask = 0;
		}
	}
}
