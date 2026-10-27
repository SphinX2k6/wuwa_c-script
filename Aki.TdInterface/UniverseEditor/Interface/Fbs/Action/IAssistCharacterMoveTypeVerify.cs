using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200619C RID: 24988
	public static class IAssistCharacterMoveTypeVerify
	{
		// Token: 0x0602B0A9 RID: 176297 RVA: 0x005EFB96 File Offset: 0x005EDD96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
