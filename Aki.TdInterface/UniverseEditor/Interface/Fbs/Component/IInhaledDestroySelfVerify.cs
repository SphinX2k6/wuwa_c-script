using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540C RID: 21516
	public static class IInhaledDestroySelfVerify
	{
		// Token: 0x06023560 RID: 144736 RVA: 0x004E417A File Offset: 0x004E237A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
