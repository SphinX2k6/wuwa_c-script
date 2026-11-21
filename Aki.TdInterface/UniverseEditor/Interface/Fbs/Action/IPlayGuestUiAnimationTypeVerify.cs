using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749A RID: 29850
	public static class IPlayGuestUiAnimationTypeVerify
	{
		// Token: 0x06034423 RID: 214051 RVA: 0x00709A3A File Offset: 0x00707C3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
