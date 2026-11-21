using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714D RID: 29005
	public static class ILiveUiShowConfigVerify
	{
		// Token: 0x06032633 RID: 206387 RVA: 0x006CFAD2 File Offset: 0x006CDCD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
