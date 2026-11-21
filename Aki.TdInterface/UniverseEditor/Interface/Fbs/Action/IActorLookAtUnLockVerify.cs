using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006753 RID: 26451
	public static class IActorLookAtUnLockVerify
	{
		// Token: 0x0602CD3C RID: 183612 RVA: 0x006216DA File Offset: 0x0061F8DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
