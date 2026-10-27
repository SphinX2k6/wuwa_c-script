using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1F RID: 27935
	public static class IPlayGuestUiAnimationTypeVerify
	{
		// Token: 0x0603142B RID: 201771 RVA: 0x006AE3F6 File Offset: 0x006AC5F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
