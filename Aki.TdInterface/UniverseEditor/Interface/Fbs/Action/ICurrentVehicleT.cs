using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5E RID: 27486
	public class ICurrentVehicleT
	{
		// Token: 0x1700C9C5 RID: 51653
		// (get) Token: 0x0602F4CF RID: 193743 RVA: 0x00674EA6 File Offset: 0x006730A6
		// (set) Token: 0x0602F4D0 RID: 193744 RVA: 0x00674EAE File Offset: 0x006730AE
		public ETargetVehicle Type { get; set; }

		// Token: 0x0602F4D1 RID: 193745 RVA: 0x00674EB7 File Offset: 0x006730B7
		public ICurrentVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}
