using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F22 RID: 16162
	public static class IMechaTrackScoreDetectionTypeVerify
	{
		// Token: 0x06016F2F RID: 93999 RVA: 0x0034FBCA File Offset: 0x0034DDCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
