using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C0 RID: 25024
	public static class IAvgFocusRoleVerify
	{
		// Token: 0x0602B1E1 RID: 176609 RVA: 0x005F1C2E File Offset: 0x005EFE2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
