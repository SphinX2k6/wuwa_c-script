using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007646 RID: 30278
	public static class TAssistCharacterMoveTypeVerify
	{
		// Token: 0x0603722F RID: 225839 RVA: 0x00779E9C File Offset: 0x0077809C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAssistCharacterSplineMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAssistCharacterNavigationMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
