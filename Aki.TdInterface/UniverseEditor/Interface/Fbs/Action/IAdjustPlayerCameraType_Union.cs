using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006170 RID: 24944
	public enum IAdjustPlayerCameraType_Union : byte
	{
		// Token: 0x0401064C RID: 67148
		NONE,
		// Token: 0x0401064D RID: 67149
		IAdjustPlayerCameraType,
		// Token: 0x0401064E RID: 67150
		IAdjustBasicCamera,
		// Token: 0x0401064F RID: 67151
		IAdjustHorizontalCamera,
		// Token: 0x04010650 RID: 67152
		IAdjustDialogCamera,
		// Token: 0x04010651 RID: 67153
		IAdjustFixedCamera,
		// Token: 0x04010652 RID: 67154
		IAdjustAxisLockCamera,
		// Token: 0x04010653 RID: 67155
		IAdjustFirstPersonCamera,
		// Token: 0x04010654 RID: 67156
		IAdjustFixedLookAtCamera,
		// Token: 0x04010655 RID: 67157
		IAdjustZoneFollowCamera,
		// Token: 0x04010656 RID: 67158
		IAdjustFixedSurveillanceCamera
	}
}
