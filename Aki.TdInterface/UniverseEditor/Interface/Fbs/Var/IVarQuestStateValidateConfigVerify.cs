using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F15 RID: 16149
	public static class IVarQuestStateValidateConfigVerify
	{
		// Token: 0x06015EF4 RID: 89844 RVA: 0x00327646 File Offset: 0x00325846
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
