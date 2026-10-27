using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006503 RID: 25859
	public static class ICustomScreenLoadingCyberpunkVerify
	{
		// Token: 0x0602CDC2 RID: 183746 RVA: 0x006298E2 File Offset: 0x00627AE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
