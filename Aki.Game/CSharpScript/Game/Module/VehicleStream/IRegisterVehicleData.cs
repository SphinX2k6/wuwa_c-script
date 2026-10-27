using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048AB RID: 18603
	[NullableContext(1)]
	public interface IRegisterVehicleData
	{
		// Token: 0x17007954 RID: 31060
		// (get) Token: 0x06030A04 RID: 199172
		int VehiclePbDataId { get; }

		// Token: 0x17007955 RID: 31061
		// (get) Token: 0x06030A05 RID: 199173
		int StartRoadId { get; }

		// Token: 0x17007956 RID: 31062
		// (get) Token: 0x06030A06 RID: 199174
		int StartRoadIndex { get; }

		// Token: 0x17007957 RID: 31063
		// (get) Token: 0x06030A07 RID: 199175
		int DestRoadId { get; }

		// Token: 0x17007958 RID: 31064
		// (get) Token: 0x06030A08 RID: 199176
		int DestIndex { get; }

		// Token: 0x17007959 RID: 31065
		// (get) Token: 0x06030A09 RID: 199177
		Vector ActorLocation { get; }

		// Token: 0x1700795A RID: 31066
		// (get) Token: 0x06030A0A RID: 199178
		Rotator ActorRotator { get; }

		// Token: 0x1700795B RID: 31067
		// (get) Token: 0x06030A0B RID: 199179
		ITrafficNavigationConfig BaseConfig { get; }
	}
}
