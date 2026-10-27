using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049CC RID: 18892
	public static class ICheckDollGrabItemComboAchievedInOnceDeliveryVerify
	{
		// Token: 0x0601D7FB RID: 120827 RVA: 0x004277D0 File Offset: 0x004259D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
