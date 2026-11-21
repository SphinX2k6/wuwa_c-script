using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004360 RID: 17248
	public static class IMechaTrackScoreDetectionTypeVerify
	{
		// Token: 0x06018587 RID: 99719 RVA: 0x00378DF2 File Offset: 0x00376FF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
