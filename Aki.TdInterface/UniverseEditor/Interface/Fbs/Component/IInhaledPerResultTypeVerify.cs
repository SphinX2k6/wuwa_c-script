using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599B RID: 22939
	public static class IInhaledPerResultTypeVerify
	{
		// Token: 0x06025666 RID: 153190 RVA: 0x00521AF2 File Offset: 0x0051FCF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
