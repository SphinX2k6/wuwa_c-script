using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003822 RID: 14370
	[NullableContext(1)]
	public interface IRegisterVehicleData
	{
		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x06025530 RID: 152880
		int VehiclePbDataId { get; }

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x06025531 RID: 152881
		int StartRoadId { get; }

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x06025532 RID: 152882
		int StartRoadIndex { get; }

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x06025533 RID: 152883
		int DestRoadId { get; }

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x06025534 RID: 152884
		int DestIndex { get; }

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x06025535 RID: 152885
		Vector ActorLocation { get; }

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x06025536 RID: 152886
		Rotator ActorRotator { get; }

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x06025537 RID: 152887
		ITrafficNavigationConfig BaseConfig { get; }
	}
}
