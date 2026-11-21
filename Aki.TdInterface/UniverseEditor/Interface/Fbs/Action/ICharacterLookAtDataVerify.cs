using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B0 RID: 27056
	public static class ICharacterLookAtDataVerify
	{
		// Token: 0x0602E69B RID: 190107 RVA: 0x0065580A File Offset: 0x00653A0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
