using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591A RID: 22810
	public static class IHitLogicChangeCountDownStateVerify
	{
		// Token: 0x0602515B RID: 151899 RVA: 0x005170E6 File Offset: 0x005152E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
