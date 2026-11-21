using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F00 RID: 16128
	public static class IVarBooleanValidateConfigVerify
	{
		// Token: 0x06015DFC RID: 89596 RVA: 0x00325296 File Offset: 0x00323496
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
