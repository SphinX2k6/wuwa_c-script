using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D7B RID: 15739
	public static class ICheckTrapDefenseEventBaseVerify
	{
		// Token: 0x06015CAA RID: 89258 RVA: 0x00324372 File Offset: 0x00322572
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
