using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004270 RID: 17008
	public static class IVisionSystemQuestBaseVerify
	{
		// Token: 0x060192C4 RID: 103108 RVA: 0x0039E0AE File Offset: 0x0039C2AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
