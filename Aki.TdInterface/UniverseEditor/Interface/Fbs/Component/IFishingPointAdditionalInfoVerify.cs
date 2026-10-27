using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005263 RID: 21091
	public static class IFishingPointAdditionalInfoVerify
	{
		// Token: 0x060224F4 RID: 140532 RVA: 0x004C1ADA File Offset: 0x004BFCDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
