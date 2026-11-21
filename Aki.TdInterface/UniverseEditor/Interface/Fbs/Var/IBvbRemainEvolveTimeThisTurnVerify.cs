using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E61 RID: 15969
	public static class IBvbRemainEvolveTimeThisTurnVerify
	{
		// Token: 0x06015820 RID: 88096 RVA: 0x0031A022 File Offset: 0x00318222
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
