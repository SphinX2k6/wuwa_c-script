using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007147 RID: 28999
	public static class ILiveUiPauseConfigVerify
	{
		// Token: 0x0603260F RID: 206351 RVA: 0x006CF7E2 File Offset: 0x006CD9E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
