using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007051 RID: 28753
	public static class IInteractPointConfigVerify
	{
		// Token: 0x06031DCA RID: 204234 RVA: 0x006C00FA File Offset: 0x006BE2FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
