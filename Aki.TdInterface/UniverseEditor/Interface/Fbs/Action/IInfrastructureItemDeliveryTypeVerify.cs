using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695F RID: 26975
	public static class IInfrastructureItemDeliveryTypeVerify
	{
		// Token: 0x0602F193 RID: 192915 RVA: 0x0066AEF2 File Offset: 0x006690F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
