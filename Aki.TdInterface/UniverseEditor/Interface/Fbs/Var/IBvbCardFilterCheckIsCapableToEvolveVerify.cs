using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E10 RID: 15888
	public static class IBvbCardFilterCheckIsCapableToEvolveVerify
	{
		// Token: 0x060155B9 RID: 87481 RVA: 0x00315E40 File Offset: 0x00314040
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
