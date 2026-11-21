using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A81 RID: 31361
	public static class ITalkEffectActionTypeVerify
	{
		// Token: 0x06037470 RID: 226416 RVA: 0x00761972 File Offset: 0x0075FB72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
