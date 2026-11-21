using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E54 RID: 32340
	public static class TAssistCharacterMoveTypeVerify
	{
		// Token: 0x0603A6D4 RID: 239316 RVA: 0x007DDF98 File Offset: 0x007DC198
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
