using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D5 RID: 26581
	public enum IAdjustPlayerCameraType_Union : byte
	{
		// Token: 0x04011453 RID: 70739
		NONE,
		// Token: 0x04011454 RID: 70740
		IAdjustPlayerCameraType,
		// Token: 0x04011455 RID: 70741
		IAdjustBasicCamera,
		// Token: 0x04011456 RID: 70742
		IAdjustHorizontalCamera,
		// Token: 0x04011457 RID: 70743
		IAdjustDialogCamera,
		// Token: 0x04011458 RID: 70744
		IAdjustFixedCamera,
		// Token: 0x04011459 RID: 70745
		IAdjustAxisLockCamera,
		// Token: 0x0401145A RID: 70746
		IAdjustFirstPersonCamera,
		// Token: 0x0401145B RID: 70747
		IAdjustFixedLookAtCamera,
		// Token: 0x0401145C RID: 70748
		IAdjustZoneFollowCamera,
		// Token: 0x0401145D RID: 70749
		IAdjustFixedSurveillanceCamera
	}
}
