using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F13 RID: 20243
	public static class ICheckHoldingHandsCharacterTypeVerify
	{
		// Token: 0x0601F73C RID: 128828 RVA: 0x00461172 File Offset: 0x0045F372
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
