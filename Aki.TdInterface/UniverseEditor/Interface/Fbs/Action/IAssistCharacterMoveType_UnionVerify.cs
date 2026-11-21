using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680A RID: 26634
	public static class IAssistCharacterMoveType_UnionVerify
	{
		// Token: 0x0602D7E8 RID: 186344 RVA: 0x0063A530 File Offset: 0x00638730
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAssistCharacterMoveTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAssistCharacterNavigationMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAssistCharacterSplineMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
