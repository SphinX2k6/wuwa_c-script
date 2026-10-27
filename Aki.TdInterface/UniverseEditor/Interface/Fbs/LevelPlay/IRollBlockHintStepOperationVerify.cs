using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200458C RID: 17804
	public static class IRollBlockHintStepOperationVerify
	{
		// Token: 0x0601AE4E RID: 110158 RVA: 0x003D6746 File Offset: 0x003D4946
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
