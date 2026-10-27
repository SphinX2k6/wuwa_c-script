using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ECD RID: 20173
	public static class IAudioControlTypeVerify
	{
		// Token: 0x0601FCB4 RID: 130228 RVA: 0x0046CE9E File Offset: 0x0046B09E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
