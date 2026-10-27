using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007745 RID: 30533
	public static class TOpenSystemBoardWithReturnVerify
	{
		// Token: 0x060377A3 RID: 227235 RVA: 0x007827F0 File Offset: 0x007809F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOpenConfirmBox2WithReturnVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenConfirmBoxWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOpenFishingItemDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IOpenGiantDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IOpenGreatSwordChallengeResultVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IOpenInfrastructureItemDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IOpenMotorRaceChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IOpenSoaringChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IOpenVillageInfrDeliveryWithReturnVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
