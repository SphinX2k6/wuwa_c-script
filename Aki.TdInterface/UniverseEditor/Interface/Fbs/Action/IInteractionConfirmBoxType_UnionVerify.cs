using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698F RID: 27023
	public static class IInteractionConfirmBoxType_UnionVerify
	{
		// Token: 0x0602F317 RID: 193303 RVA: 0x0066D8C4 File Offset: 0x0066BAC4
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
