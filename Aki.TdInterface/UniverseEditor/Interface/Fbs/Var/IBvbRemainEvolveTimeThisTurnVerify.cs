using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A86 RID: 14982
	public static class IBvbRemainEvolveTimeThisTurnVerify
	{
		// Token: 0x06014504 RID: 83204 RVA: 0x002F6E36 File Offset: 0x002F5036
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
