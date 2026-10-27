using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004482 RID: 17538
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraRestitutionMergeType.ENiagaraRestitutionMergeType")]
	public enum ENiagaraRestitutionMergeType : byte
	{
		// Token: 0x04018280 RID: 98944
		Ignore,
		// Token: 0x04018281 RID: 98945
		Min,
		// Token: 0x04018282 RID: 98946
		Max,
		// Token: 0x04018283 RID: 98947
		Average,
		// Token: 0x04018284 RID: 98948
		ENiagaraRestitutionMergeType_MAX
	}
}
