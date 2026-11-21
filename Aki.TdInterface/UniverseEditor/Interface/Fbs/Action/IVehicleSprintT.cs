using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D29 RID: 32041
	public class IVehicleSprintT
	{
		// Token: 0x1700EFD9 RID: 61401
		// (get) Token: 0x06039D8E RID: 236942 RVA: 0x007CE0A1 File Offset: 0x007CC2A1
		// (set) Token: 0x06039D8F RID: 236943 RVA: 0x007CE0A9 File Offset: 0x007CC2A9
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x06039D90 RID: 236944 RVA: 0x007CE0B2 File Offset: 0x007CC2B2
		public IVehicleSprintT()
		{
			this.TargetVehicle = null;
		}
	}
}
