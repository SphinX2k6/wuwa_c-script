using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E23 RID: 32291
	public static class IWindProtagonistParkour5Verify
	{
		// Token: 0x0603A5A0 RID: 239008 RVA: 0x007DC082 File Offset: 0x007DA282
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
