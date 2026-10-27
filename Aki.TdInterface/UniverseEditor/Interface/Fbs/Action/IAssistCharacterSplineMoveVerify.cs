using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A5 RID: 24997
	public static class IAssistCharacterSplineMoveVerify
	{
		// Token: 0x0602B0E7 RID: 176359 RVA: 0x005F01E8 File Offset: 0x005EE3E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
