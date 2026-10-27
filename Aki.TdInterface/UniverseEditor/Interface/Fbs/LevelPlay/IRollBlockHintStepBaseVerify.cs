using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004583 RID: 17795
	public static class IRollBlockHintStepBaseVerify
	{
		// Token: 0x0601AE12 RID: 110098 RVA: 0x003D61B2 File Offset: 0x003D43B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
