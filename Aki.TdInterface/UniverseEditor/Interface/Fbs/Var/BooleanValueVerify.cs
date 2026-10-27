using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x020039ED RID: 14829
	public static class BooleanValueVerify
	{
		// Token: 0x060140F6 RID: 82166 RVA: 0x002F017A File Offset: 0x002EE37A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
