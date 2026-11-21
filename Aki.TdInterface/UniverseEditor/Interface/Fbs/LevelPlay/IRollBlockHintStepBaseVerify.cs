using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049EB RID: 18923
	public static class IRollBlockHintStepBaseVerify
	{
		// Token: 0x0601C5E7 RID: 116199 RVA: 0x0040244E File Offset: 0x0040064E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
