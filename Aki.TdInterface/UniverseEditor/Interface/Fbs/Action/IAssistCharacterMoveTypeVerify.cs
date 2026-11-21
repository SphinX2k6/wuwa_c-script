using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006807 RID: 26631
	public static class IAssistCharacterMoveTypeVerify
	{
		// Token: 0x0602D7DA RID: 186330 RVA: 0x0063A40A File Offset: 0x0063860A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
