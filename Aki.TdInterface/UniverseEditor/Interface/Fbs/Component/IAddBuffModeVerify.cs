using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E5B RID: 20059
	public static class IAddBuffModeVerify
	{
		// Token: 0x0601F7DF RID: 128991 RVA: 0x00462F92 File Offset: 0x00461192
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
