using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD1 RID: 15057
	public static class ISelfVarRefVerify
	{
		// Token: 0x060147C4 RID: 83908 RVA: 0x002FBEA5 File Offset: 0x002FA0A5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
