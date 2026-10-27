using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004465 RID: 17509
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraBooleanLogicOps_v2.ENiagaraBooleanLogicOps_v2")]
	public enum ENiagaraBooleanLogicOps_v2 : byte
	{
		// Token: 0x040181E7 RID: 98791
		A_Greater_Than_B,
		// Token: 0x040181E8 RID: 98792
		A_Greater_Than_Or_Equal_To_B,
		// Token: 0x040181E9 RID: 98793
		A_Equal_To_B,
		// Token: 0x040181EA RID: 98794
		A_Not_Equal_To_B,
		// Token: 0x040181EB RID: 98795
		A_Less_Than_B,
		// Token: 0x040181EC RID: 98796
		A_Less_Than_Or_Equal_To_B,
		// Token: 0x040181ED RID: 98797
		ENiagaraBooleanLogicOps_MAX
	}
}
