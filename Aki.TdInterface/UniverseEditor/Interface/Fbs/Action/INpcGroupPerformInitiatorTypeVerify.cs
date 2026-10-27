using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBA RID: 27578
	public static class INpcGroupPerformInitiatorTypeVerify
	{
		// Token: 0x0603072A RID: 198442 RVA: 0x0069447E File Offset: 0x0069267E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
