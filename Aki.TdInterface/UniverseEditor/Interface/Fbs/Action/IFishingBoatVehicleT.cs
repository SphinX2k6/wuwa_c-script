using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E46 RID: 28230
	public class IFishingBoatVehicleT
	{
		// Token: 0x1700CEEA RID: 52970
		// (get) Token: 0x06030C33 RID: 199731 RVA: 0x0069E3D2 File Offset: 0x0069C5D2
		// (set) Token: 0x06030C34 RID: 199732 RVA: 0x0069E3DA File Offset: 0x0069C5DA
		public ETargetVehicle Type { get; set; }

		// Token: 0x06030C35 RID: 199733 RVA: 0x0069E3E3 File Offset: 0x0069C5E3
		public IFishingBoatVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}
