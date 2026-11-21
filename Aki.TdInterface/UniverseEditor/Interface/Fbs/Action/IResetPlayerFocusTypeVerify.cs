using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761D RID: 30237
	public static class IResetPlayerFocusTypeVerify
	{
		// Token: 0x060350EA RID: 217322 RVA: 0x0072068E File Offset: 0x0071E88E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
