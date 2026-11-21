using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006891 RID: 26769
	public static class IBpActorFuncTypeBaseVerify
	{
		// Token: 0x0602DC34 RID: 187444 RVA: 0x006417D6 File Offset: 0x0063F9D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
