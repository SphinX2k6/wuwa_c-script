using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044AC RID: 17580
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_SpawnBurstMode.ENiagara_SpawnBurstMode")]
	public enum ENiagara_SpawnBurstMode : byte
	{
		// Token: 0x04018355 RID: 99157
		Timed,
		// Token: 0x04018356 RID: 99158
		Manual,
		// Token: 0x04018357 RID: 99159
		ENiagara_MAX
	}
}
