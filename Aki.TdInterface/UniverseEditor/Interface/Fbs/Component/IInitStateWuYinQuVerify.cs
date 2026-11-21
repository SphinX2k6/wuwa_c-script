using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B3 RID: 22963
	public static class IInitStateWuYinQuVerify
	{
		// Token: 0x06025720 RID: 153376 RVA: 0x00522E12 File Offset: 0x00521012
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
