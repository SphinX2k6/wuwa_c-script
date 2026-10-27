using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A8 RID: 29608
	public static class ITeleportTransitionType_UnionVerify
	{
		// Token: 0x06035C04 RID: 220164 RVA: 0x00751024 File Offset: 0x0074F224
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITeleportTransitionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITeleportTransitionWithMp4Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITeleportTransitionWithEffectVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITeleportTransitionWithCenterTextVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITeleportTransitionWithFadeInScreenVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITeleportTransitionInDigitalScreenVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITeleportTransitionWithCustomLoadingVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITeleportTransitionWithSpecialCustomLoadingVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ITeleportTransitionWithPlayFlowVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITeleportTransitionWithCustomScreenVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ITeleportTransitionInSeamlessTypeVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ITeleportTransitionWithCharacterDisplayVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
