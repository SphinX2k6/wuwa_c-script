using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200520B RID: 21003
	public enum IVehicleCondition_Union : byte
	{
		// Token: 0x0400E218 RID: 57880
		NONE,
		// Token: 0x0400E219 RID: 57881
		IVehicleCondition,
		// Token: 0x0400E21A RID: 57882
		ICheckIsUsingVehicle,
		// Token: 0x0400E21B RID: 57883
		ICheckIsPlayerUsingVehicle,
		// Token: 0x0400E21C RID: 57884
		ICheckVehicleSpeedCondition,
		// Token: 0x0400E21D RID: 57885
		ICheckVehicleTriggerAngleCondition
	}
}
