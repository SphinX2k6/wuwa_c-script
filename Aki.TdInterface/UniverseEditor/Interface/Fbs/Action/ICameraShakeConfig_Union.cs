using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A5 RID: 25253
	public enum ICameraShakeConfig_Union : byte
	{
		// Token: 0x0401083C RID: 67644
		NONE,
		// Token: 0x0401083D RID: 67645
		ICameraShakeConfig,
		// Token: 0x0401083E RID: 67646
		IConstantCameraShake,
		// Token: 0x0401083F RID: 67647
		ILinearOverRangeCameraShake
	}
}
