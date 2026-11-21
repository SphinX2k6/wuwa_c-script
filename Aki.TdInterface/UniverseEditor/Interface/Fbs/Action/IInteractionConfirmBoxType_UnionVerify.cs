using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007042 RID: 28738
	public static class IInteractionConfirmBoxType_UnionVerify
	{
		// Token: 0x06031CE7 RID: 204007 RVA: 0x006BDDAC File Offset: 0x006BBFAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractionConfirmBoxTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonConfirmBoxVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHonamiStoryCorruptedChestConfirmBoxVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHonamiStoryEvacuateConfirmBoxVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
