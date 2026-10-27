using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D2 RID: 28882
	public static class ISheriffUnlockProgressVerify
	{
		// Token: 0x06033275 RID: 209525 RVA: 0x006E5932 File Offset: 0x006E3B32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
