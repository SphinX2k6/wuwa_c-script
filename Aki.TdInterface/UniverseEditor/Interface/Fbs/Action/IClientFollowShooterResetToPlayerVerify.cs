using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063CC RID: 25548
	public static class IClientFollowShooterResetToPlayerVerify
	{
		// Token: 0x0602C312 RID: 181010 RVA: 0x00611286 File Offset: 0x0060F486
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
