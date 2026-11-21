using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200436F RID: 17263
	public static class IMechaTrackScoreTagDetectionVerify
	{
		// Token: 0x060185F3 RID: 99827 RVA: 0x0037996A File Offset: 0x00377B6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
