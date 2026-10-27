using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E65 RID: 15973
	public static class IFlipperConditionStepFightVerify
	{
		// Token: 0x060167C9 RID: 92105 RVA: 0x0034017E File Offset: 0x0033E37E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
