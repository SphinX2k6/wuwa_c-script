using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F6E RID: 32622
	public static class TOpenSystemBoardWithReturnVerify
	{
		// Token: 0x0603ACE0 RID: 240864 RVA: 0x007E77B4 File Offset: 0x007E59B4
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
				result = IOpenMechaStuntTrackChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IOpenMotorRaceChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IOpenSoaringChallengeResultWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 10:
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
