using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200447D RID: 17533
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraNumericVariableTypes.ENiagaraNumericVariableTypes")]
	public enum ENiagaraNumericVariableTypes : byte
	{
		// Token: 0x04018265 RID: 98917
		Float,
		// Token: 0x04018266 RID: 98918
		Vector_2D,
		// Token: 0x04018267 RID: 98919
		Vector_3D,
		// Token: 0x04018268 RID: 98920
		Vector_4D,
		// Token: 0x04018269 RID: 98921
		Linear_Color,
		// Token: 0x0401826A RID: 98922
		Quaternion,
		// Token: 0x0401826B RID: 98923
		ENiagaraNumericVariableTypes_MAX
	}
}
