using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E4B RID: 32331
	public static class TAdjustPlayerCameraOptionVerify
	{
		// Token: 0x0603A6AC RID: 239276 RVA: 0x007DDBA8 File Offset: 0x007DBDA8
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
