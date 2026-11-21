using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F4 RID: 18932
	public static class IRollBlockHintStepOperationVerify
	{
		// Token: 0x0601C623 RID: 116259 RVA: 0x004029E2 File Offset: 0x00400BE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
