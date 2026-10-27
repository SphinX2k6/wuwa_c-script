using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200447F RID: 17535
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraQuaternionDerivationTechnique.ENiagaraQuaternionDerivationTechnique")]
	public enum ENiagaraQuaternionDerivationTechnique : byte
	{
		// Token: 0x04018272 RID: 98930
		X_Vector,
		// Token: 0x04018273 RID: 98931
		X_And_Y_Vectors,
		// Token: 0x04018274 RID: 98932
		X_And_Z_Vectors,
		// Token: 0x04018275 RID: 98933
		ENiagaraQuaternionDerivationTechnique_MAX
	}
}
