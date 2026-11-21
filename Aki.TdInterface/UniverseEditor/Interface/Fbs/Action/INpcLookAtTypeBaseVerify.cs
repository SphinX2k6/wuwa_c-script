using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007339 RID: 29497
	public static class INpcLookAtTypeBaseVerify
	{
		// Token: 0x0603370D RID: 210701 RVA: 0x006EF3B6 File Offset: 0x006ED5B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
