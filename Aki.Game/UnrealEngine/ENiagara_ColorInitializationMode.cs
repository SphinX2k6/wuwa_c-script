using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004499 RID: 17561
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_ColorInitializationMode.ENiagara_ColorInitializationMode")]
	public enum ENiagara_ColorInitializationMode : byte
	{
		// Token: 0x040182F5 RID: 99061
		Unset,
		// Token: 0x040182F6 RID: 99062
		Direct_Set,
		// Token: 0x040182F7 RID: 99063
		Random_Range,
		// Token: 0x040182F8 RID: 99064
		Random_Hue_Saturation_Value,
		// Token: 0x040182F9 RID: 99065
		ENiagara_MAX
	}
}
