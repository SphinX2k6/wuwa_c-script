using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051FE RID: 20990
	public static class ITrafficMatchTargetTypeVerify
	{
		// Token: 0x060210F8 RID: 135416 RVA: 0x0049182E File Offset: 0x0048FA2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
