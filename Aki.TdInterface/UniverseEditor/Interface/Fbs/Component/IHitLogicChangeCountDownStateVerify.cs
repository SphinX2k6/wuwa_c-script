using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005394 RID: 21396
	public static class IHitLogicChangeCountDownStateVerify
	{
		// Token: 0x060230A7 RID: 143527 RVA: 0x004DA212 File Offset: 0x004D8412
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
