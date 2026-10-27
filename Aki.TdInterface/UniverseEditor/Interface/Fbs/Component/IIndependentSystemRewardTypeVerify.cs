using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F4 RID: 21492
	public static class IIndependentSystemRewardTypeVerify
	{
		// Token: 0x060234BA RID: 144570 RVA: 0x004E2F4E File Offset: 0x004E114E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
