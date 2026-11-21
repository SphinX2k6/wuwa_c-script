using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F06 RID: 16134
	public static class IVarEntityValidateConfigVerify
	{
		// Token: 0x06015E58 RID: 89688 RVA: 0x0032625E File Offset: 0x0032445E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
