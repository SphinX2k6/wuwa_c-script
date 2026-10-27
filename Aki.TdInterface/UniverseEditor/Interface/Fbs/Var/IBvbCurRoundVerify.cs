using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A4A RID: 14922
	public static class IBvbCurRoundVerify
	{
		// Token: 0x0601435B RID: 82779 RVA: 0x002F4282 File Offset: 0x002F2482
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
