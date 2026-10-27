using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D0F RID: 19727
	public enum IVehicleCondition_Union : byte
	{
		// Token: 0x0400D6EB RID: 55019
		NONE,
		// Token: 0x0400D6EC RID: 55020
		IVehicleCondition,
		// Token: 0x0400D6ED RID: 55021
		ICheckIsUsingVehicle,
		// Token: 0x0400D6EE RID: 55022
		ICheckIsPlayerUsingVehicle,
		// Token: 0x0400D6EF RID: 55023
		ICheckVehicleSpeedCondition,
		// Token: 0x0400D6F0 RID: 55024
		ICheckVehicleTriggerAngleCondition
	}
}
