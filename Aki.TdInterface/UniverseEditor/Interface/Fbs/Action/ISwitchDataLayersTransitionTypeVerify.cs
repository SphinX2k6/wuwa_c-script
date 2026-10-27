using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007252 RID: 29266
	public static class ISwitchDataLayersTransitionTypeVerify
	{
		// Token: 0x06033EA5 RID: 212645 RVA: 0x006FBAE2 File Offset: 0x006F9CE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
