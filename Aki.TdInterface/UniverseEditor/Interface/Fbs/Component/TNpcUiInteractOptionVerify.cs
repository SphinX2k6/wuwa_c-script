using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062A5 RID: 25253
	public static class TNpcUiInteractOptionVerify
	{
		// Token: 0x0602AF32 RID: 175922 RVA: 0x005DC138 File Offset: 0x005DA338
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcUiInteractOnAntiqueShopVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcUiInteractOnChengXiaoShanShopVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcUiInteractOnDollGrabDeliveryVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INpcUiInteractOnGramophoneVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = INpcUiInteractOnHandInItemVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = INpcUiInteractOnShopVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = INpcUiInteractOnShopNewVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = INpcUiInteractOnSoundBox3Verify.Verify(verifier, tablePos);
				break;
			case 9:
				result = INpcUiInteractOnSoundBox35Verify.Verify(verifier, tablePos);
				break;
			case 10:
				result = INpcUiInteractOnSunSpiritVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = INpcUiInteractOnVillageInfrVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
