using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F18 RID: 16152
	public static class IVarQuestValidateConfigVerify
	{
		// Token: 0x06015F06 RID: 89862 RVA: 0x003277BE File Offset: 0x003259BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
