using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A55 RID: 23125
	public static class ILevelAiCycleModeTypeVerify
	{
		// Token: 0x06025D3B RID: 154939 RVA: 0x0052F536 File Offset: 0x0052D736
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
