using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006172 RID: 24946
	public static class IAdjustPlayerCameraType_UnionVerify
	{
		// Token: 0x0602AF0F RID: 175887 RVA: 0x005EC990 File Offset: 0x005EAB90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAdjustPlayerCameraTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAdjustBasicCameraVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAdjustHorizontalCameraVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAdjustDialogCameraVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IAdjustFixedCameraVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IAdjustAxisLockCameraVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IAdjustFirstPersonCameraVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IAdjustFixedLookAtCameraVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IAdjustZoneFollowCameraVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IAdjustFixedSurveillanceCameraVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
