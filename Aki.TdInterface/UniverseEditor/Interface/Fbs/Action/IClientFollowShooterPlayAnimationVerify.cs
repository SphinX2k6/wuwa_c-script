using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C9 RID: 25545
	public static class IClientFollowShooterPlayAnimationVerify
	{
		// Token: 0x0602C300 RID: 180992 RVA: 0x00611103 File Offset: 0x0060F303
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
