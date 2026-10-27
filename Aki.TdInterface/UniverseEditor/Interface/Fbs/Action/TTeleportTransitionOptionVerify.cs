using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D9 RID: 30681
	public static class TTeleportTransitionOptionVerify
	{
		// Token: 0x06037A81 RID: 227969 RVA: 0x00786C44 File Offset: 0x00784E44
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITeleportTransitionInDigitalScreenVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITeleportTransitionInSeamlessTypeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITeleportTransitionWithCenterTextVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITeleportTransitionWithCharacterDisplayVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITeleportTransitionWithCustomLoadingVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITeleportTransitionWithCustomScreenVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITeleportTransitionWithEffectVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITeleportTransitionWithFadeInScreenVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ITeleportTransitionWithMp4Verify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITeleportTransitionWithPlayFlowVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ITeleportTransitionWithSpecialCustomLoadingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
