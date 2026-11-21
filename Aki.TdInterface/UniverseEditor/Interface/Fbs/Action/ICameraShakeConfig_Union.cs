using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006916 RID: 26902
	public enum ICameraShakeConfig_Union : byte
	{
		// Token: 0x04011651 RID: 71249
		NONE,
		// Token: 0x04011652 RID: 71250
		ICameraShakeConfig,
		// Token: 0x04011653 RID: 71251
		IConstantCameraShake,
		// Token: 0x04011654 RID: 71252
		ILinearOverRangeCameraShake
	}
}
