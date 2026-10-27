using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F31 RID: 16177
	public static class IMechaTrackScoreTagDetectionVerify
	{
		// Token: 0x06016F9B RID: 94107 RVA: 0x00350742 File Offset: 0x0034E942
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
