using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B16 RID: 15126
	public static class IVarQuestValidateConfigVerify
	{
		// Token: 0x06014A5C RID: 84572 RVA: 0x0030152E File Offset: 0x002FF72E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
