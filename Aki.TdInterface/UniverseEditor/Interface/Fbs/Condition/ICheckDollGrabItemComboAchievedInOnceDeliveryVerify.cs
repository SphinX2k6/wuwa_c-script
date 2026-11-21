using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E8C RID: 20108
	public static class ICheckDollGrabItemComboAchievedInOnceDeliveryVerify
	{
		// Token: 0x0601F26E RID: 127598 RVA: 0x0045843C File Offset: 0x0045663C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
