using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FD RID: 30205
	public static class IWaitMovieModeBorderAnimFinishedVerify
	{
		// Token: 0x0603705B RID: 225371 RVA: 0x007771B6 File Offset: 0x007753B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
