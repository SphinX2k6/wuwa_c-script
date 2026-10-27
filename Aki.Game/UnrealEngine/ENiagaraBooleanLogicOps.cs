using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004464 RID: 17508
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraBooleanLogicOps.ENiagaraBooleanLogicOps")]
	public enum ENiagaraBooleanLogicOps : byte
	{
		// Token: 0x040181E1 RID: 98785
		Greater_Than,
		// Token: 0x040181E2 RID: 98786
		Greater_Than_Or_Equal_To,
		// Token: 0x040181E3 RID: 98787
		Equal_To,
		// Token: 0x040181E4 RID: 98788
		Not_Equal_To,
		// Token: 0x040181E5 RID: 98789
		ENiagaraBooleanLogicOps_MAX
	}
}
