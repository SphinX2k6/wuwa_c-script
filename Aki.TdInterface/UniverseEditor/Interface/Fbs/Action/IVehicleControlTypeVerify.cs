using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF1 RID: 31985
	public static class IVehicleControlTypeVerify
	{
		// Token: 0x06039B5D RID: 236381 RVA: 0x007C8F36 File Offset: 0x007C7136
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
