using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007533 RID: 30003
	public class IVehicleSprintT
	{
		// Token: 0x1700E3AF RID: 58287
		// (get) Token: 0x06036978 RID: 223608 RVA: 0x0076ADF9 File Offset: 0x00768FF9
		// (set) Token: 0x06036979 RID: 223609 RVA: 0x0076AE01 File Offset: 0x00769001
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x0603697A RID: 223610 RVA: 0x0076AE0A File Offset: 0x0076900A
		public IVehicleSprintT()
		{
			this.TargetVehicle = null;
		}
	}
}
