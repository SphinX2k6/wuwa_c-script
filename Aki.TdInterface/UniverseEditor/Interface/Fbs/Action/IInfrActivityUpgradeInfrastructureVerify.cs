using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006956 RID: 26966
	public static class IInfrActivityUpgradeInfrastructureVerify
	{
		// Token: 0x0602F155 RID: 192853 RVA: 0x0066A97A File Offset: 0x00668B7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
