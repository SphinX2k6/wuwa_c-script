using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044A9 RID: 17577
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_PositionInitializationMode.ENiagara_PositionInitializationMode")]
	public enum ENiagara_PositionInitializationMode : byte
	{
		// Token: 0x04018342 RID: 99138
		Unset,
		// Token: 0x04018343 RID: 99139
		Direct_Set,
		// Token: 0x04018344 RID: 99140
		Simulation_Position,
		// Token: 0x04018345 RID: 99141
		ENiagara_MAX
	}
}
