using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B04 RID: 15108
	public static class IVarEntityValidateConfigVerify
	{
		// Token: 0x060149AE RID: 84398 RVA: 0x002FFFCE File Offset: 0x002FE1CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
