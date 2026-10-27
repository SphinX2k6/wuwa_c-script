using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D0E RID: 19726
	public static class IVehicleConditionVerify
	{
		// Token: 0x0601F4F5 RID: 128245 RVA: 0x0045DE42 File Offset: 0x0045C042
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
