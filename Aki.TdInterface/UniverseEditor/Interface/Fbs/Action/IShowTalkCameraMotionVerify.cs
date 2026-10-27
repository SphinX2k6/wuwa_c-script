using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F0 RID: 28912
	public static class IShowTalkCameraMotionVerify
	{
		// Token: 0x060333EE RID: 209902 RVA: 0x006E8E06 File Offset: 0x006E7006
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
