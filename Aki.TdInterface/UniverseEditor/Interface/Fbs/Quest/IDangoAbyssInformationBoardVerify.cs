using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DD RID: 16861
	public static class IDangoAbyssInformationBoardVerify
	{
		// Token: 0x06017653 RID: 95827 RVA: 0x003581E2 File Offset: 0x003563E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
