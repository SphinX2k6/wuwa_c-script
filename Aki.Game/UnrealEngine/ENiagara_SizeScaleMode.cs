using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044AB RID: 17579
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_SizeScaleMode.ENiagara_SizeScaleMode")]
	public enum ENiagara_SizeScaleMode : byte
	{
		// Token: 0x0401834E RID: 99150
		Unset,
		// Token: 0x0401834F RID: 99151
		Uniform,
		// Token: 0x04018350 RID: 99152
		Random_Uniform,
		// Token: 0x04018351 RID: 99153
		Non_Uniform,
		// Token: 0x04018352 RID: 99154
		Random_Non_Uniform,
		// Token: 0x04018353 RID: 99155
		ENiagara_MAX
	}
}
