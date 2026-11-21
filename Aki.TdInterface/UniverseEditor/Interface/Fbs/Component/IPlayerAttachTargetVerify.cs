using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D51 RID: 23889
	public static class IPlayerAttachTargetVerify
	{
		// Token: 0x06027C38 RID: 162872 RVA: 0x00570D1E File Offset: 0x0056EF1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
