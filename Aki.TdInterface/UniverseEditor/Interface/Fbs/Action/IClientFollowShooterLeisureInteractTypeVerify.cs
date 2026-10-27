using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C3 RID: 25539
	public static class IClientFollowShooterLeisureInteractTypeVerify
	{
		// Token: 0x0602C2DA RID: 180954 RVA: 0x00610D92 File Offset: 0x0060EF92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
