using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCB RID: 28619
	public static class ISetBehaviorIsPausedVerify
	{
		// Token: 0x06032957 RID: 207191 RVA: 0x006D34E2 File Offset: 0x006D16E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
