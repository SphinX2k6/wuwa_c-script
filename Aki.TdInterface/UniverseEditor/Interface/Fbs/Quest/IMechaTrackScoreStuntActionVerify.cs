using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F2E RID: 16174
	public static class IMechaTrackScoreStuntActionVerify
	{
		// Token: 0x06016F89 RID: 94089 RVA: 0x003505CA File Offset: 0x0034E7CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
