using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC3 RID: 28355
	public static class IResumeGiantDeliveryRewardPopupVerify
	{
		// Token: 0x060321D4 RID: 205268 RVA: 0x006C672A File Offset: 0x006C492A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
