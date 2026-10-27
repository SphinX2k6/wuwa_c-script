using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B33 RID: 23347
	public class IViewDistanceModeT
	{
		// Token: 0x1700B038 RID: 45112
		// (get) Token: 0x06027E72 RID: 163442 RVA: 0x0057C976 File Offset: 0x0057AB76
		// (set) Token: 0x06027E73 RID: 163443 RVA: 0x0057C97E File Offset: 0x0057AB7E
		public EViewDistanceType Type { get; set; }

		// Token: 0x06027E74 RID: 163444 RVA: 0x0057C987 File Offset: 0x0057AB87
		public IViewDistanceModeT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
