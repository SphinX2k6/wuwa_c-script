using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682E RID: 26670
	public static class IAvgFocusRoleVerify
	{
		// Token: 0x0602D928 RID: 186664 RVA: 0x0063C6A2 File Offset: 0x0063A8A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
