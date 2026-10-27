using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007348 RID: 29512
	public static class ITalkOptionQteFailedDelayExecVerify
	{
		// Token: 0x060358E7 RID: 219367 RVA: 0x0074B57E File Offset: 0x0074977E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
