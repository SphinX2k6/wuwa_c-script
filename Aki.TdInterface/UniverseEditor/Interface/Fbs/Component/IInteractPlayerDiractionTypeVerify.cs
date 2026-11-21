using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E9 RID: 23017
	public static class IInteractPlayerDiractionTypeVerify
	{
		// Token: 0x0602595E RID: 153950 RVA: 0x005278B6 File Offset: 0x00525AB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
