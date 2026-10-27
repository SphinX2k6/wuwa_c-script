using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763D RID: 30269
	public static class TAdjustPlayerCameraOptionVerify
	{
		// Token: 0x06037207 RID: 225799 RVA: 0x00779AAC File Offset: 0x00777CAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAdjustAxisLockCameraVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAdjustBasicCameraVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAdjustDialogCameraVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAdjustFirstPersonCameraVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IAdjustFixedCameraVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IAdjustFixedLookAtCameraVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IAdjustFixedSurveillanceCameraVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IAdjustHorizontalCameraVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IAdjustZoneFollowCameraVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
