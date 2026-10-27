using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ADD RID: 15069
	public static class ISystemVarDefineVerify
	{
		// Token: 0x06014856 RID: 84054 RVA: 0x002FCF44 File Offset: 0x002FB144
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
