using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E68 RID: 28264
	public static class IFloatingSubtitleLanguageDiffVerify
	{
		// Token: 0x06030D34 RID: 199988 RVA: 0x0069FE96 File Offset: 0x0069E096
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
