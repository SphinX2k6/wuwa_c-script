using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752D RID: 29997
	public static class IProgramSpecialConfigBaseVerify
	{
		// Token: 0x060349A4 RID: 215460 RVA: 0x007141DE File Offset: 0x007123DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
