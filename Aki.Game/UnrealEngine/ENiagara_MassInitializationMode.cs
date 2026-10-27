using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044A7 RID: 17575
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_MassInitializationMode.ENiagara_MassInitializationMode")]
	public enum ENiagara_MassInitializationMode : byte
	{
		// Token: 0x04018337 RID: 99127
		Unset____Mass_of_1_,
		// Token: 0x04018338 RID: 99128
		Direct_Set,
		// Token: 0x04018339 RID: 99129
		Random,
		// Token: 0x0401833A RID: 99130
		ENiagara_MAX
	}
}
