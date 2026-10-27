using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A4D RID: 19021
	public static class ICheckHoldingHandsCharacterTypeVerify
	{
		// Token: 0x0601DC99 RID: 122009 RVA: 0x0042FFE6 File Offset: 0x0042E1E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
