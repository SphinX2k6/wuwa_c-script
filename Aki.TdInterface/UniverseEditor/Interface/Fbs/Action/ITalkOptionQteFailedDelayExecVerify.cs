using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B20 RID: 31520
	public static class ITalkOptionQteFailedDelayExecVerify
	{
		// Token: 0x06038C1A RID: 232474 RVA: 0x007AD106 File Offset: 0x007AB306
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
