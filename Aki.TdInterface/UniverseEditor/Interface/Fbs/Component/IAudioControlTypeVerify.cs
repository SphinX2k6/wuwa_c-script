using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FC RID: 21500
	public static class IAudioControlTypeVerify
	{
		// Token: 0x060219F8 RID: 137720 RVA: 0x004A2C6E File Offset: 0x004A0E6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
