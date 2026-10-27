using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411A RID: 16666
	public static class ISheriffReasoningBoardConfigVerify
	{
		// Token: 0x06018678 RID: 99960 RVA: 0x003851F6 File Offset: 0x003833F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
