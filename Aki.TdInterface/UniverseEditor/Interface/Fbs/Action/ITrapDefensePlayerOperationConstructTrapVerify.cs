using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C52 RID: 31826
	public static class ITrapDefensePlayerOperationConstructTrapVerify
	{
		// Token: 0x060395EC RID: 234988 RVA: 0x007BEF72 File Offset: 0x007BD172
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
