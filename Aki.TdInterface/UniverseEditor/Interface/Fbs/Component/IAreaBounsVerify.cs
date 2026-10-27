using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB8 RID: 20152
	public static class IAreaBounsVerify
	{
		// Token: 0x0601FBC7 RID: 129991 RVA: 0x0046AFF2 File Offset: 0x004691F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
