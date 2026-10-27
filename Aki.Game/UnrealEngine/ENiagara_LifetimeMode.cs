using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044A6 RID: 17574
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_LifetimeMode.ENiagara_LifetimeMode")]
	public enum ENiagara_LifetimeMode : byte
	{
		// Token: 0x04018333 RID: 99123
		Direct_Set,
		// Token: 0x04018334 RID: 99124
		Random,
		// Token: 0x04018335 RID: 99125
		ENiagara_MAX
	}
}
