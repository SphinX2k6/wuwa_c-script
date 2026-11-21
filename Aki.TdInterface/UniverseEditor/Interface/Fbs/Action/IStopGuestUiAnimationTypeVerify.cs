using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A9 RID: 31145
	public static class IStopGuestUiAnimationTypeVerify
	{
		// Token: 0x06036E14 RID: 224788 RVA: 0x00756FE6 File Offset: 0x007551E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
