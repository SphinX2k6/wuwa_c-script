using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714A RID: 29002
	public static class ILiveUiResumeConfigVerify
	{
		// Token: 0x06032621 RID: 206369 RVA: 0x006CF95A File Offset: 0x006CDB5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
