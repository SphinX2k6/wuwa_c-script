using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005691 RID: 22161
	public static class INpcUiInteractType_UnionVerify
	{
		// Token: 0x06024FA0 RID: 151456 RVA: 0x0051B428 File Offset: 0x00519628
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcUiInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcUiInteractOnHandInItemVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcUiInteractOnShopVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INpcUiInteractOnAntiqueShopVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = INpcUiInteractOnChengXiaoShanShopVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = INpcUiInteractOnGramophoneVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = INpcUiInteractOnSoundBox3Verify.Verify(verifier, tablePos);
				break;
			case 8:
				result = INpcUiInteractOnSunSpiritVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = INpcUiInteractOnShopNewVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = INpcUiInteractOnVillageInfrVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = INpcUiInteractOnSoundBox35Verify.Verify(verifier, tablePos);
				break;
			case 12:
				result = INpcUiInteractOnDollGrabDeliveryVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
