using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200449B RID: 17563
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_DirectReadApplicationMode.ENiagara_DirectReadApplicationMode")]
	public enum ENiagara_DirectReadApplicationMode : byte
	{
		// Token: 0x040182FF RID: 99071
		Overwrite,
		// Token: 0x04018300 RID: 99072
		Add,
		// Token: 0x04018301 RID: 99073
		ENiagara_MAX
	}
}
