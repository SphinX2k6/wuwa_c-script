using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004468 RID: 17512
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraCollisionRadiusOptions.ENiagaraCollisionRadiusOptions")]
	public enum ENiagaraCollisionRadiusOptions : byte
	{
		// Token: 0x040181F9 RID: 98809
		Sprite,
		// Token: 0x040181FA RID: 98810
		Mesh,
		// Token: 0x040181FB RID: 98811
		Custom,
		// Token: 0x040181FC RID: 98812
		ENiagaraCollisionRadiusOptions_MAX
	}
}
