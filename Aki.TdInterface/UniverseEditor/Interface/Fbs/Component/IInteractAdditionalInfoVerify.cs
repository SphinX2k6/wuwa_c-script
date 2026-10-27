using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005433 RID: 21555
	public static class IInteractAdditionalInfoVerify
	{
		// Token: 0x06023690 RID: 145040 RVA: 0x004E61AA File Offset: 0x004E43AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
