using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722E RID: 29230
	public static class ISubtitleStyleNewLevelBVerify
	{
		// Token: 0x06033D93 RID: 212371 RVA: 0x006F9FAE File Offset: 0x006F81AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
