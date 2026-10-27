using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B13 RID: 15123
	public static class IVarQuestStateValidateConfigVerify
	{
		// Token: 0x06014A4A RID: 84554 RVA: 0x003013B6 File Offset: 0x002FF5B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
