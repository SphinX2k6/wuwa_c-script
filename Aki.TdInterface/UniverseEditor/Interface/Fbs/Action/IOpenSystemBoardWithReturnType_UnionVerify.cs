using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A8 RID: 29608
	public static class IOpenSystemBoardWithReturnType_UnionVerify
	{
		// Token: 0x06033C70 RID: 212080 RVA: 0x006FBFF4 File Offset: 0x006FA1F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOpenSystemBoardWithReturnTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenConfirmBoxWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOpenConfirmBox2WithReturnVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IOpenSoaringChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IOpenMotorRaceChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IOpenMechaStuntTrackChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IOpenFishingItemDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IOpenInfrastructureItemDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IOpenVillageInfrDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IOpenGreatSwordChallengeResultVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IOpenGiantDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
