using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005831 RID: 22577
	public static class IRefreshOnHostInteractVerify
	{
		// Token: 0x06025F96 RID: 155542 RVA: 0x0053C46E File Offset: 0x0053A66E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
