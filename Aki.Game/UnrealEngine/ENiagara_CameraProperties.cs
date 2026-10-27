using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004497 RID: 17559
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_CameraProperties.ENiagara_CameraProperties")]
	public enum ENiagara_CameraProperties : byte
	{
		// Token: 0x040182EA RID: 99050
		Camera_Position,
		// Token: 0x040182EB RID: 99051
		Camera_Forward_Vector,
		// Token: 0x040182EC RID: 99052
		Camera_Up_Vector,
		// Token: 0x040182ED RID: 99053
		Camera_Right_Vector,
		// Token: 0x040182EE RID: 99054
		Vector_To_Camera,
		// Token: 0x040182EF RID: 99055
		ENiagara_MAX
	}
}
