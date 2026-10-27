using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA7 RID: 15015
	public static class IntValueVerify
	{
		// Token: 0x0601465D RID: 83549 RVA: 0x002F970E File Offset: 0x002F790E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
