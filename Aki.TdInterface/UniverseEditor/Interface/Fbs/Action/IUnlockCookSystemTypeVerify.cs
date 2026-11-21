using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC4 RID: 31940
	public static class IUnlockCookSystemTypeVerify
	{
		// Token: 0x060399E7 RID: 236007 RVA: 0x007C63D6 File Offset: 0x007C45D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
