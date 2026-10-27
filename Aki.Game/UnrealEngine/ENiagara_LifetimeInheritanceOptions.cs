using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044A5 RID: 17573
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_LifetimeInheritanceOptions.ENiagara_LifetimeInheritanceOptions")]
	public enum ENiagara_LifetimeInheritanceOptions : byte
	{
		// Token: 0x0401832E RID: 99118
		Min,
		// Token: 0x0401832F RID: 99119
		Max,
		// Token: 0x04018330 RID: 99120
		Overwrite,
		// Token: 0x04018331 RID: 99121
		ENiagara_MAX
	}
}
