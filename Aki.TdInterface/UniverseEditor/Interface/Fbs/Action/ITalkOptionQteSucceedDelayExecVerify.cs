using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B26 RID: 31526
	public static class ITalkOptionQteSucceedDelayExecVerify
	{
		// Token: 0x06038C3E RID: 232510 RVA: 0x007AD3F6 File Offset: 0x007AB5F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
