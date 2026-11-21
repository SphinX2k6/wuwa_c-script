using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BC RID: 27068
	public static class ICharacterLookAtPlayerDataVerify
	{
		// Token: 0x0602E6E9 RID: 190185 RVA: 0x00655F0A File Offset: 0x0065410A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
