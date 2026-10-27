using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052FF RID: 21247
	public static class IGramophoneAudioControlVerify
	{
		// Token: 0x06022B45 RID: 142149 RVA: 0x004CF2D2 File Offset: 0x004CD4D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
