using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B0 RID: 22448
	public static class IFightMusicsSwitchTypeVerify
	{
		// Token: 0x060243D8 RID: 148440 RVA: 0x004FB4AE File Offset: 0x004F96AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
