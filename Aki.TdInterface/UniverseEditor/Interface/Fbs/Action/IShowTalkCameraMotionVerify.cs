using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078BC RID: 30908
	public static class IShowTalkCameraMotionVerify
	{
		// Token: 0x06036690 RID: 222864 RVA: 0x00749412 File Offset: 0x00747612
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
