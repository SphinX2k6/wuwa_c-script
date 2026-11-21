using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E1D RID: 32285
	public static class IWindProtagonistParkour3Verify
	{
		// Token: 0x0603A57C RID: 238972 RVA: 0x007DBD92 File Offset: 0x007D9F92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
