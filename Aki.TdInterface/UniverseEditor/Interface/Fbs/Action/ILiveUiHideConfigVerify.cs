using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007144 RID: 28996
	public static class ILiveUiHideConfigVerify
	{
		// Token: 0x060325FD RID: 206333 RVA: 0x006CF66A File Offset: 0x006CD86A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
