using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC8 RID: 15048
	public static class IScoreDisplayParamsVerify
	{
		// Token: 0x0601477F RID: 83839 RVA: 0x002FB67E File Offset: 0x002F987E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
