using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D4 RID: 29140
	public static class IStopGuestUiAnimationTypeVerify
	{
		// Token: 0x06033B12 RID: 211730 RVA: 0x006F5C86 File Offset: 0x006F3E86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
