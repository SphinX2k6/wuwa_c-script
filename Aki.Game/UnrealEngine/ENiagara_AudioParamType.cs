using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004494 RID: 17556
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_AudioParamType.ENiagara_AudioParamType")]
	public enum ENiagara_AudioParamType : byte
	{
		// Token: 0x040182D8 RID: 99032
		Volume,
		// Token: 0x040182D9 RID: 99033
		Pitch,
		// Token: 0x040182DA RID: 99034
		Location,
		// Token: 0x040182DB RID: 99035
		Rotation,
		// Token: 0x040182DC RID: 99036
		Boolean_Parameter,
		// Token: 0x040182DD RID: 99037
		Float_Parameter,
		// Token: 0x040182DE RID: 99038
		Integer_Parameter,
		// Token: 0x040182DF RID: 99039
		Paused_State,
		// Token: 0x040182E0 RID: 99040
		ENiagara_MAX
	}
}
