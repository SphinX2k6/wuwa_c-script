using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A27 RID: 31271
	public static class ISwitchDataLayersTransitionTypeVerify
	{
		// Token: 0x060371A7 RID: 225703 RVA: 0x0075CE42 File Offset: 0x0075B042
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
