using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424F RID: 16975
	public static class IEventTypeConfigVerify
	{
		// Token: 0x06017A10 RID: 96784 RVA: 0x0035EA76 File Offset: 0x0035CC76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
