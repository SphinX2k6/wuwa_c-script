using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748B RID: 29835
	public static class IPlayerSlideRailEndVerify
	{
		// Token: 0x060343B1 RID: 213937 RVA: 0x00708EAE File Offset: 0x007070AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
