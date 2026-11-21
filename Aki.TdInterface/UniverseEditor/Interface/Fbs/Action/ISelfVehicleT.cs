using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771E RID: 30494
	public class ISelfVehicleT
	{
		// Token: 0x1700DF99 RID: 57241
		// (get) Token: 0x06035809 RID: 219145 RVA: 0x0072C2DA File Offset: 0x0072A4DA
		// (set) Token: 0x0603580A RID: 219146 RVA: 0x0072C2E2 File Offset: 0x0072A4E2
		public ETargetVehicle Type { get; set; }

		// Token: 0x0603580B RID: 219147 RVA: 0x0072C2EB File Offset: 0x0072A4EB
		public ISelfVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}
