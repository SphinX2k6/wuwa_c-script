using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713B RID: 28987
	public static class ILiveUiConfigVerify
	{
		// Token: 0x060325BF RID: 206271 RVA: 0x006CF0A6 File Offset: 0x006CD2A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
