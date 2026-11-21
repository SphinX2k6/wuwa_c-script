using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DA RID: 27098
	public static class ICheckFlowLookAtTargetVerify
	{
		// Token: 0x0602E7DA RID: 190426 RVA: 0x00657C06 File Offset: 0x00655E06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
