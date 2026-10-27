using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582E RID: 22574
	public static class IRefreshOnDeathVerify
	{
		// Token: 0x06025F84 RID: 155524 RVA: 0x0053C2F6 File Offset: 0x0053A4F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
