using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007647 RID: 30279
	public static class IResumeGiantDeliveryRewardPopupVerify
	{
		// Token: 0x06035214 RID: 217620 RVA: 0x0072245E File Offset: 0x0072065E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
