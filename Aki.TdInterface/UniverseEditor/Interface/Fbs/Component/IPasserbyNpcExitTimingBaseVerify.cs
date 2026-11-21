using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C74 RID: 23668
	public static class IPasserbyNpcExitTimingBaseVerify
	{
		// Token: 0x06027432 RID: 160818 RVA: 0x00560A9E File Offset: 0x0055EC9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
