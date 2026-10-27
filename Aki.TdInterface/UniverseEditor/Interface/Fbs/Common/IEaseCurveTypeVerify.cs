using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D9C RID: 23964
	public static class IEaseCurveTypeVerify
	{
		// Token: 0x06029033 RID: 167987 RVA: 0x005A1E7E File Offset: 0x005A007E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
