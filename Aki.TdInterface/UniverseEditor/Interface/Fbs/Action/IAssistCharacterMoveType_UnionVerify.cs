using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200619F RID: 24991
	public static class IAssistCharacterMoveType_UnionVerify
	{
		// Token: 0x0602B0B7 RID: 176311 RVA: 0x005EFCBC File Offset: 0x005EDEBC
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
