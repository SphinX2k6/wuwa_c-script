using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF3 RID: 15859
	public static class IEnableSystemConfigVerify
	{
		// Token: 0x060162CA RID: 90826 RVA: 0x00333F6A File Offset: 0x0033216A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
