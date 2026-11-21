using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200436C RID: 17260
	public static class IMechaTrackScoreStuntActionVerify
	{
		// Token: 0x060185E1 RID: 99809 RVA: 0x003797F2 File Offset: 0x003779F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
