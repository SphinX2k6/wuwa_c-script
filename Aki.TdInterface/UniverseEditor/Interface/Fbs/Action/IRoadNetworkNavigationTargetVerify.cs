using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007659 RID: 30297
	public static class IRoadNetworkNavigationTargetVerify
	{
		// Token: 0x0603528A RID: 217738 RVA: 0x00722F5E File Offset: 0x0072115E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
