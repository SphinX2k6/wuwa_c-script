using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AFE RID: 15102
	public static class IVarBooleanValidateConfigVerify
	{
		// Token: 0x06014952 RID: 84306 RVA: 0x002FF006 File Offset: 0x002FD206
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
