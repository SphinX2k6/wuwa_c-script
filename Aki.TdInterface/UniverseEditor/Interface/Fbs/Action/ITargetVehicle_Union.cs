using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B42 RID: 31554
	public enum ITargetVehicle_Union : byte
	{
		// Token: 0x04013175 RID: 78197
		NONE,
		// Token: 0x04013176 RID: 78198
		ITargetVehicle,
		// Token: 0x04013177 RID: 78199
		ICurrentVehicle,
		// Token: 0x04013178 RID: 78200
		ISelfVehicle,
		// Token: 0x04013179 RID: 78201
		IAppointedVehicle,
		// Token: 0x0401317A RID: 78202
		ITriggeredVehicle,
		// Token: 0x0401317B RID: 78203
		IFishingBoatVehicle,
		// Token: 0x0401317C RID: 78204
		IVehicleTeam,
		// Token: 0x0401317D RID: 78205
		IVehiclePlayerMotor
	}
}
