using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B40 RID: 31552
	public class ITargetVehicleT
	{
		// Token: 0x1700EC52 RID: 60498
		// (get) Token: 0x06038D2D RID: 232749 RVA: 0x007AF20A File Offset: 0x007AD40A
		// (set) Token: 0x06038D2E RID: 232750 RVA: 0x007AF212 File Offset: 0x007AD412
		public ETargetVehicle Type { get; set; }

		// Token: 0x06038D2F RID: 232751 RVA: 0x007AF21B File Offset: 0x007AD41B
		public ITargetVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}
