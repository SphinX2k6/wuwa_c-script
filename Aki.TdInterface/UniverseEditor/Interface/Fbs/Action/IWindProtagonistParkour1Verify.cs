using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E17 RID: 32279
	public static class IWindProtagonistParkour1Verify
	{
		// Token: 0x0603A558 RID: 238936 RVA: 0x007DBAA2 File Offset: 0x007D9CA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
