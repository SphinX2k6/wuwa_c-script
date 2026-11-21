using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E0B RID: 32267
	public static class IWaitMovieModeBorderAnimFinishedVerify
	{
		// Token: 0x0603A500 RID: 238848 RVA: 0x007DB2B2 File Offset: 0x007D94B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
