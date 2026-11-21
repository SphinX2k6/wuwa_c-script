using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E55 RID: 15957
	public static class IBvbNpcScoreVerify
	{
		// Token: 0x060157D8 RID: 88024 RVA: 0x00319A42 File Offset: 0x00317C42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
