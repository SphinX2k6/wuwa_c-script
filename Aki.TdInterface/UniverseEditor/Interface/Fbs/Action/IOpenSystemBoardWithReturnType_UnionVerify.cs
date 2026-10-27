using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C41 RID: 27713
	public static class IOpenSystemBoardWithReturnType_UnionVerify
	{
		// Token: 0x06030D15 RID: 199957 RVA: 0x006A1B00 File Offset: 0x0069FD00
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
				result = IOpenFishingItemDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IOpenInfrastructureItemDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IOpenVillageInfrDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IOpenGreatSwordChallengeResultVerify.Verify(verifier, tablePos);
				break;
			case 10:
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
