using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007367 RID: 29543
	public enum ITargetVehicle_Union : byte
	{
		// Token: 0x0401216C RID: 74092
		NONE,
		// Token: 0x0401216D RID: 74093
		ITargetVehicle,
		// Token: 0x0401216E RID: 74094
		ICurrentVehicle,
		// Token: 0x0401216F RID: 74095
		ISelfVehicle,
		// Token: 0x04012170 RID: 74096
		IAppointedVehicle,
		// Token: 0x04012171 RID: 74097
		ITriggeredVehicle,
		// Token: 0x04012172 RID: 74098
		IFishingBoatVehicle,
		// Token: 0x04012173 RID: 74099
		IVehicleTeam,
		// Token: 0x04012174 RID: 74100
		IVehiclePlayerMotor
	}
}
