using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005260 RID: 21088
	public static class IFireElementalMatchVerify
	{
		// Token: 0x060224E2 RID: 140514 RVA: 0x004C1962 File Offset: 0x004BFB62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
